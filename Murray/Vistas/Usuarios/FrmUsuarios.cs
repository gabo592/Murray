using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murray.Vistas.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarInfoUsuarios(object sender, EventArgs args)
        {
            FrmInfoUsuarios infoUsuarios = new FrmInfoUsuarios();
            infoUsuarios.ShowDialog();
        }
    }
}
