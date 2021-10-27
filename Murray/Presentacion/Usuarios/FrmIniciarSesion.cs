using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Murray.Controladores;

namespace Murray.Presentacion
{
    public partial class FrmIniciarSesion : Form
    {
        private readonly ControladorUsuario controlador;

        public FrmIniciarSesion()
        {
            InitializeComponent();
            controlador = new ControladorUsuario(this);
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.SeleccionarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbRegresar_Click(object sender, EventArgs e)
        {
            controlador.RegresarAFrameAnterior(this, new FrmBienvenida());
        }

        private void FrmIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
