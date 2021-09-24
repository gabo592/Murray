using System;
using System.Windows.Forms;
using Murray.Properties;
using Murray.Poco;
using Murray.Utilidades;
using Murray.Presentacion.Principal;

namespace Murray.Presentacion
{
    public partial class UserPassword : Form
    {
        private readonly Usuario usuario;

        public UserPassword(Usuario usuario)
        {
            InitializeComponent();
            lblMensaje.Visible = false;
            this.usuario = usuario;
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

                if (txtPass.Text.Equals(usuario.Pass))
                {
                    Close();
                    FrmPrincipal principal = new FrmPrincipal(usuario);
                    principal.Show();
                }
                else
                {
                    MessageBox.Show(this, "Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LblContra_Click(object sender, EventArgs e)
        {
            RecuperarPass();
        }

        private void RecuperarPass()
        {
            try
            {
                txtHtml.Text = txtHtml.Text.Replace("@pass", usuario.Pass);
                txtHtml.Text = txtHtml.Text.Replace("@primerNombre", usuario.PrimerNombre);
                txtHtml.Text = txtHtml.Text.Replace("@primerApellido", usuario.PrimerApellido);

                Asistente.EnviarCorreo(Settings.Default.Correo, Settings.Default.PassCorreo, txtHtml.Text, "Solicitud de Contraseña", usuario.Correo);

                MessageBox.Show(this, $"Se ha enviado la contraseña a {usuario.Correo}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
