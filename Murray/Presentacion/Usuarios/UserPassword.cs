using System;
using System.Windows.Forms;
using Murray.Properties;

namespace Murray.Presentacion
{
    public partial class UserPassword : Form
    {
        public UserPassword()
        {
            InitializeComponent();
            lblMensaje.Visible = false;
        }

        private void PbMostrarPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar.Equals('*'))
            {
                txtPass.PasswordChar = '\0';
                pbMostrarPass.Image = Resources.invisible;
            }
            else
            {
                txtPass.PasswordChar = '*';
                pbMostrarPass.Image = Resources.eye;
            }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    lblMensaje.Visible = true;
                    return;
                }

                UserCard.Pass = txtPass.Text;
                Close();
            }
        }

        private void LblContra_Click(object sender, EventArgs e)
        {
            FrmRecuperarContrasena frmRecuperar = new FrmRecuperarContrasena();
            frmRecuperar.ShowDialog();
        }

        private void UserPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                UserCard.Pass = "none";
            }
        }
    }
}
