using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Murray.Poco;
using Murray.Properties;
using System.IO;
using System.Data;
using Murray.Utilidades;

namespace Murray.Modelos
{
    public class UsuarioModel
    {
        private readonly string Conexion;
        public DataTable DataTableUsuarios { get; set; }

        public UsuarioModel()
        {
            Conexion = Settings.Default.ConnectionStrings;
            DataTableUsuarios = new DataTable();
        }

        public Usuario CrearUsuario(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string alias, string pass, Image imagen, string cargo, string correo, int idMunicipio)
        {
            return new Usuario()
            {
                PrimerNombre = primerNombre,
                SegundoNombre = segundoNombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Alias = alias,
                Pass = pass,
                Imagen = imagen,
                Cargo = cargo,
                Correo = correo,
                ID_Municipio = idMunicipio
            };
        }

        public void InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(Conexion))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("insertar_usuario", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@primerNombre", usuario.PrimerNombre);
                command.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre);
                command.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido);
                command.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido);
                command.Parameters.AddWithValue("@alias", usuario.Alias);
                command.Parameters.AddWithValue("@pass", usuario.Pass);

                MemoryStream memoryStream = new MemoryStream();
                usuario.Imagen.Save(memoryStream, usuario.Imagen.RawFormat);
                command.Parameters.AddWithValue("@avatar", memoryStream.GetBuffer());

                command.Parameters.AddWithValue("@cargo", usuario.Cargo);
                command.Parameters.AddWithValue("@correo", usuario.Correo);
                command.Parameters.AddWithValue("@idMunicipio", usuario.ID_Municipio);

                command.ExecuteNonQuery();
            }
        }

        public void SeleccionarUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectionStrings))
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("extraer_usuario", connection);
                dataAdapter.Fill(DataTableUsuarios);
            }
        }

        public Usuario CargarUsuarios(DataTable dataTable, int indice)
        {
            Usuario usuario = new Usuario
            {
                ID = (int)dataTable.Rows[indice]["ID"],
                PrimerNombre = dataTable.Rows[indice]["Primer Nombre"].ToString(),
                SegundoNombre = dataTable.Rows[indice]["Segundo Nombre"].ToString(),
                PrimerApellido = dataTable.Rows[indice]["Primer Apellido"].ToString(),
                SegundoApellido = dataTable.Rows[indice]["Segundo Apellido"].ToString(),
                Alias = dataTable.Rows[indice]["Alias"].ToString(),
                Pass = dataTable.Rows[indice]["Pass"].ToString(),
                Imagen = Asistente.ObtenerImagen((byte[])dataTable.Rows[indice]["Avatar"]),
                Cargo = dataTable.Rows[indice]["Cargo"].ToString(),
                Estado = dataTable.Rows[indice]["Estado"].ToString(),
                Correo = dataTable.Rows[indice]["Correo"].ToString(),
                ID_Municipio = (int)dataTable.Rows[indice]["ID_Municipio"]
            };

            return usuario;
        }
    }
}
