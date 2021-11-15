using System;
using System.Drawing;
using System.Windows.Forms;
using Common.Util;
using Murray.Services.Identity;

namespace Murray.Vistas
{
    public partial class FrmLogin : Form
    {
        #region Dependencias

        /// <summary>
        ///     Servicio de autenticacion de usuario
        /// </summary>
        private readonly Login Service;

        /// <summary>
        ///     Administrador de erroes
        /// </summary>
        private readonly ErrorHandler Handler;

        #endregion

        public FrmLogin()
        {
            Handler = new ErrorHandler();
            Service = new Login(Handler);

            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DoLogin();
            }
        }

        #region Private Methods

        private void DoLogin()
        {
            Service.DoLogin(txtUsuario.Text, txtContraseña.Text);

            if (Handler.HasError())
                MessageBox.Show(this, Handler.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void txtUsuario_Enter(object sender, EventArgs e)
        //{
        //    if (txtUsuario.Text == "USUARIO") 
        //    {
        //        txtUsuario.Text = " ";
        //        txtUsuario.ForeColor = Color.Blue;
            
        //    }
        //}

        //private void txtUsuario_Leave(object sender, EventArgs e)
        //{
        //    if (txtUsuario.Text == " ")
        //    {
        //        txtUsuario.Text = "USUARIO";
        //        txtUsuario.ForeColor = Color.Black;

        //    }

        //}

        //private void txtContraseña_Enter(object sender, EventArgs e)
        //{
        //    if (txtContraseña.Text == "CONTRASEÑA")
        //    {
        //        txtContraseña.Text = "";
        //        txtContraseña.ForeColor = Color.Blue;
        //        txtContraseña.UseSystemPasswordChar = true;
                
        //    }
        //}

        //private void txtContraseña_Leave(object sender, EventArgs e)
        //{
        //    if (txtContraseña.Text == "")
        //    {
        //        txtContraseña.Text = "CONTRASEÑA";
        //        txtContraseña.ForeColor = Color.Black;
        //        txtContraseña.UseSystemPasswordChar = false;

        //    }
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = " ";
                txtUsuario.ForeColor = Color.Blue;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == " ")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Black;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Blue;
                txtContraseña.UseSystemPasswordChar = true;

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
