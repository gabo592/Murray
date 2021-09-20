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

namespace Murray.Presentacion.Principal
{
    public partial class FrmPrincipal : Form
    {
        private readonly Usuario usuario; 

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pbUsuario.Image = usuario.Imagen;
        }

        private void CargarFrame(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string name = pictureBox.Name;

            if (name.Contains("Clientes"))
            {
                MessageBox.Show(this, "Sección clientes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (name.Contains("Productos"))
            {
                MessageBox.Show(this, "Sección Productos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
