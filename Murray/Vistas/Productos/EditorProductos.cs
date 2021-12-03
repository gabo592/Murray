using Common.Util;
using Models.Interfaces;
using Murray.Services.Common;

using System;
using System.Linq;
using System.Windows.Forms;

namespace Murray.Vistas.Productos
{
    public partial class EditorProductos : Form
    {
        private readonly ErrorHandler Handler;
        private readonly StockService Service;

        /// <summary>
        ///     Registro a interactuar
        /// </summary>
        private Models.Common.Producto Record;

        public EditorProductos()
        {
            Handler = new ErrorHandler();
            Service = new StockService(Handler);

            InitializeComponent();

            Categorias.DataSource = Service.GetCategorias().ToArray();
            Categorias.DisplayMember = nameof(INameable.Nombre);
        }

        #region Public Methods

        public void LoadRecord(int id)
        {
            Record = id.Equals(default) ? new Models.Common.Producto() : Service.GetProduct(id);
        }

        #endregion

        #region Private Methods

        private void ApplyChanges()
        {
            if (Record is null)
                Record = new Models.Common.Producto();

            Record.Descripcion = Descripcion.Text;
            Record.IdCategoria = ((Models.Common.Categoria)Categorias.SelectedItem).Id;
            Record.Precio = Precio.Value;
            Record.Estado = true;
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            Service.SaveProduct(Record);
            Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
