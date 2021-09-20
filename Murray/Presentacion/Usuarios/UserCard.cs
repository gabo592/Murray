using System;
using System.Windows.Forms;
using Murray.Poco;
using Murray.Presentacion.Principal;

namespace Murray.Presentacion
{
    public partial class UserCard : UserControl
    {
        private readonly Usuario usuario;
        public static string Pass;
        private readonly FrmIniciarSesion iniciarSesion;

        public UserCard(Usuario usuario, FrmIniciarSesion iniciarSesion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.iniciarSesion = iniciarSesion;
        }

        private void UserCard_Load(object sender, EventArgs e)
        {
            pbImagen.Image = usuario.Imagen;
            lblNickName.Text = usuario.NickName;
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

            FrmPrincipal principal = new FrmPrincipal(usuario);
            principal.Show();

            iniciarSesion.Hide();
        }

        private bool ValidarPass()
        {
            return Pass.Equals(usuario.Pass);
        }
    }
}
