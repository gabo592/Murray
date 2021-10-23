using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murray.Presentacion.Productos
{
    public partial class FrmSeleccion : Form
    {
        public FrmSeleccion()
        {
            InitializeComponent();
        }

        private void VerTodos_Click(object sender, EventArgs args)
        {
            FrmProductos productos = new FrmProductos();
            productos.ShowDialog();
            Close();
        }

        private void VerCategorias_Click(object sender, EventArgs args)
        {
            FrmCategorias categorias = new FrmCategorias();
            categorias.ShowDialog();
            Close();
        }
    }
}
