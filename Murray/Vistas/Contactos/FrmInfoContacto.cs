using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murray.Vistas.Contactos
{
    public partial class FrmInfoContacto : Form
    {
        public FrmInfoContacto()
        {
            InitializeComponent();
        }

        private void Salir(object sender, EventArgs args)
        {
            Close();
        }
    }
}
