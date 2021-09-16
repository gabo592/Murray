using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Murray.Poco;
using Murray.Properties;

namespace Murray.Presentacion
{
    public partial class UserCard : UserControl
    {
        private readonly Usuario Usuario;
        public static string Pass;
        private readonly DataTable DataTable;
        private FrmIniciarSesion iniciarSesion;

        public UserCard(Usuario usuario, FrmIniciarSesion iniciarSesion)
        {
            InitializeComponent();
            Usuario = usuario;
            DataTable = new DataTable();
            this.iniciarSesion = iniciarSesion;
        }

        private void UserCard_Load(object sender, EventArgs e)
        {
            pbImagen.Image = Usuario.Imagen;
            lblNickName.Text = Usuario.NickName;
        }

        private void Click_Usuario(object sender, EventArgs args)
        {
            UserPassword password = new UserPassword();
            password.ShowDialog();

            BuscarUsuario();

            if (!ValidarUsuario())
            {
                MessageBox.Show(this, "Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            iniciarSesion.Close();
        }

        private void BuscarUsuario()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectionStrings))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("buscar_usuario", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@id", Usuario.ID);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@pass", Pass);

                    dataAdapter.Fill(DataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarUsuario()
        {
            if (DataTable.Rows.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}
