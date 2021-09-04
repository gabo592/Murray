using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Presentacion;

namespace Murray
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void PbCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta crearCuenta = new FrmCrearCuenta();
            crearCuenta.Show();
            Hide();
        }

        private void FrmBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
