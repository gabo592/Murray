using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Poco;

namespace Murray.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(this, "¿Desea cerrar el programa?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
            Application.Exit();
        }
    }
}
