using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murray.Vistas.Productos
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void MostrarCategorias(object sender, EventArgs args)
        {
            FrmCategoriasProductos categoriasProductos = new FrmCategoriasProductos();
            categoriasProductos.ShowDialog();
        }
    }
}
