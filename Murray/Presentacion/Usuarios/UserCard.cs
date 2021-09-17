using System;
using System.Windows.Forms;
using Murray.Poco;

namespace Murray.Presentacion
{
    public partial class UserCard : UserControl
    {
        private readonly Usuario Usuario;
        public static string Pass;
        private FrmIniciarSesion iniciarSesion;

        public UserCard(Usuario usuario, FrmIniciarSesion iniciarSesion)
        {
            InitializeComponent();
            Usuario = usuario;
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

            if (!ValidarPass())
            {
                MessageBox.Show(this, "Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            iniciarSesion.Close();
        }

        private bool ValidarPass()
        {
            return Pass.Equals(Usuario.Pass);
        }
    }
}
