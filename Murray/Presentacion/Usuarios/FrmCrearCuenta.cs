using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Murray.Properties;
using Murray.Enums;
using Murray.Controladores;

namespace Murray.Presentacion
{
    public partial class FrmCrearCuenta : Form
    {
        public static Image Avatar;
        private readonly ControladorUsuario controlador;

        public FrmCrearCuenta()
        {
            InitializeComponent();
            controlador = new ControladorUsuario(this);
        }

        private void PbRegresar_Click(object sender, EventArgs e)
        {
            controlador.RegresarAFrameAnterior(this, new FrmBienvenida());
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            controlador.CargarDepartamentos();
            controlador.CargarMunicipios();

            cmbCargo.Items.AddRange(Enum.GetValues(typeof(Cargos)).Cast<object>().ToArray());
            cmbCargo.SelectedIndex = 0;
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlador.CargarMunicipios();
        }

        private void PbAvatar_Click(object sender, EventArgs e)
        {
            FrmAvatares avatares = new FrmAvatares();
            avatares.ShowDialog();

            if (Avatar == null)
            {
                return;
            }

            pbAvatar.Image = Avatar;
        }

        private void PbAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.CrearCuenta();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void FrmCrearCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
