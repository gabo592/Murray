using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Murray.Vistas.Base
{
    public abstract partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        #region Protected Methods
        protected abstract void OnBuscarTxtChange(string query);
        protected abstract void OnAgregarClick(object sender, EventArgs e);
        protected abstract void OnEliminarClick(object sender, EventArgs e);
        protected abstract void OnEditarClick(object sender, EventArgs e);

        protected TModel GetSelected<TModel>()
        {
            if (DataGrid.SelectedRows.Count == 0)
                return default;

            var records = (TModel[])DataGrid.DataSource;
            return records[DataGrid.SelectedRows[0].Index];
        }
        protected void LoadDatagrid<TModel>(IEnumerable<TModel> records)
        {
            DataGrid.DataSource = records.ToArray();
        }

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            OnBuscarTxtChange(txtBuscar.Text);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OnEliminarClick(sender, e);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            OnEditarClick(sender, e);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OnAgregarClick(sender, e);
        }
    }
}
