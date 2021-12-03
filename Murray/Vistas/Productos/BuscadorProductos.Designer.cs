using Murray.ViewModels.Common;
using System;

namespace Murray.Vistas.Productos
{
    partial class BuscadorProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Vista de edición
        /// </summary>
        private System.ComponentModel.IContainer editor = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnAgregarClick(object sender, EventArgs e)
        {
            var editor = new EditorProductos();
            editor.LoadRecord(default);
            editor.ShowDialog();
        }

        protected override void OnBuscarTxtChange(string query)
        {
            LoadDatagrid<ProductoView>(Service.GetProductos(query));
        }

        protected override void OnEditarClick(object sender, EventArgs e)
        {
            var selected = GetSelected<ProductoView>();
            if (selected is null)
            {
                return;
            }

            var editor = new EditorProductos();
            editor.FormClosed += Editor_FormClosed;
            editor.LoadRecord(selected.Id);

            editor.ShowDialog();
        }

        private void Editor_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            LoadDatagrid<ProductoView>(Service.GetProductos(string.Empty));
        }

        protected override void OnEliminarClick(object sender, EventArgs e)
        {
            var selected = GetSelected<ProductoView>();
            if (selected is null)
            {
                return;
            }

            Service.DeleteProduct(selected.Id);
            LoadDatagrid<ProductoView>(Service.GetProductos(string.Empty));
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscadorProductos));
            this.SuspendLayout();
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(917, 449);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion
    }
}