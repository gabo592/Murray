using System;
using System.Windows.Forms;
using Murray.Controladores;

namespace Murray.Vistas
{
    public partial class FrmLogin : Form
    {
        private readonly ControladorUsuario controlador;

        public FrmLogin()
        {
            InitializeComponent();
            controlador = new ControladorUsuario(this);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidarUsuario();
            }
        }

        private void ValidarUsuario()
        {
            try
            {
                controlador.ValidarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
