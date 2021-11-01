using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Murray.Dao;
using Murray.Poco;
using Murray.Properties;

namespace Murray.Modelos
{
    public class UsuarioModel : IDaoUsuario
    {
        private readonly string Conexion;
        private readonly DataTable DataUsuarios;

        public UsuarioModel()
        {
            Conexion = Settings.Default.ConnectionString;
            DataUsuarios = new DataTable();
        }

        public void Actualizar(Usuario t)
        {
            throw new NotImplementedException();
        }

        public void Crear(Usuario t)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Usuario t)
        {
            throw new NotImplementedException();
        }

        public void LeerTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario ValidarUsuario(string nickName, string password)
        {
            if (DataUsuarios.Rows.Count != 0)
            {
                DataUsuarios.Clear();
            }

            using (SqlConnection connection = new SqlConnection(Conexion))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("validar_usuario", connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.AddWithValue("@nickName", nickName);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@pass", password);
                dataAdapter.Fill(DataUsuarios);
            }

            if (DataUsuarios.Rows.Count == 0)
            {
                return null;
            }

            Usuario usuario = new Usuario
            {
                ID = (int)DataUsuarios.Rows[0]["ID_Usuario"],
                NickName = DataUsuarios.Rows[0]["NickName"].ToString(),
                Password = DataUsuarios.Rows[0]["Pass"].ToString(),
                Rol = DataUsuarios.Rows[0]["Rol"].ToString(),
                ID_Empleado = (int)DataUsuarios.Rows[0]["ID_Empleado"]
            };

            return usuario;
        }
    }
}
