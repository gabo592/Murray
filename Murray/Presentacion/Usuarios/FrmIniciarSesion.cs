using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Properties;
using Murray.Poco;

namespace Murray.Presentacion
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            DataTable dataTable = CargarDatos();

            if (dataTable == null)
            {
                return;
            }

            CargarUsuarios(dataTable);
        }

        private DataTable CargarDatos()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectionStrings))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("extraer_usuario", connection);
                    dataAdapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void CargarUsuarios(DataTable dataTable)
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Usuario usuario = new Usuario
                {
                    ID = (int)dataTable.Rows[i]["ID"],
                    PrimerNombre = dataTable.Rows[i]["Primer Nombre"].ToString(),
                    SegundoNombre = dataTable.Rows[i]["Segundo Nombre"].ToString(),
                    PrimerApellido = dataTable.Rows[i]["Primer Apellido"].ToString(),
                    SegundoApellido = dataTable.Rows[i]["Segundo Apellido"].ToString(),
                    Alias = dataTable.Rows[i]["Alias"].ToString(),
                    Pass = dataTable.Rows[i]["Pass"].ToString(),
                    Imagen = ObtenerImagen((byte[])dataTable.Rows[i]["Avatar"]),
                    Cargo = dataTable.Rows[i]["Cargo"].ToString(),
                    Estado = dataTable.Rows[i]["Estado"].ToString(),
                    Correo = dataTable.Rows[i]["Correo"].ToString(),
                    ID_Municipio = (int)dataTable.Rows[i]["ID_Municipio"]
                };

                pnlPrincipal.Controls.Add(new UserCard(usuario, this));
            }
        }

        private Image ObtenerImagen(byte[] bytesImagen)
        {
            MemoryStream memoryStream = new MemoryStream(bytesImagen);
            Image imagen = Image.FromStream(memoryStream);
            return imagen;
        }

        private void PbRegresar_Click(object sender, EventArgs e)
        {
            FrmBienvenida bienvenida = new FrmBienvenida();
            bienvenida.Show();
            Hide();
        }

        private void FrmIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
