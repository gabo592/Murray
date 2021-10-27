﻿
namespace Murray.Presentacion.Productos
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.pnlBarraSup = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.pbEspacio1 = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlBarraSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspacio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraSup
            // 
            this.pnlBarraSup.Controls.Add(this.txtBuscar);
            this.pnlBarraSup.Controls.Add(this.lblAgregarProducto);
            this.pnlBarraSup.Controls.Add(this.pbAgregar);
            this.pnlBarraSup.Controls.Add(this.pbEspacio1);
            this.pnlBarraSup.Controls.Add(this.pbBuscar);
            this.pnlBarraSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSup.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSup.Name = "pnlBarraSup";
            this.pnlBarraSup.Size = new System.Drawing.Size(902, 33);
            this.pnlBarraSup.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(40, 0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(668, 31);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgregarProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(39)))));
            this.lblAgregarProducto.Location = new System.Drawing.Point(708, 0);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(135, 33);
            this.lblAgregarProducto.TabIndex = 4;
            this.lblAgregarProducto.Text = "Agregar Producto";
            this.lblAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // pbAgregar
            // 
            this.pbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAgregar.Image = global::Murray.Properties.Resources.plus;
            this.pbAgregar.Location = new System.Drawing.Point(843, 0);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(41, 33);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregar.TabIndex = 2;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // pbEspacio1
            // 
            this.pbEspacio1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEspacio1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbEspacio1.Location = new System.Drawing.Point(884, 0);
            this.pbEspacio1.Name = "pbEspacio1";
            this.pbEspacio1.Size = new System.Drawing.Size(18, 33);
            this.pbEspacio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEspacio1.TabIndex = 1;
            this.pbEspacio1.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbBuscar.Image = global::Murray.Properties.Resources.magnifying_glass;
            this.pbBuscar.Location = new System.Drawing.Point(0, 0);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(40, 33);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 0;
            this.pbBuscar.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.dgvProductos);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 33);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(902, 413);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(902, 413);
            this.dgvProductos.TabIndex = 2;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 446);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBarraSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.pnlBarraSup.ResumeLayout(false);
            this.pnlBarraSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspacio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSup;
        private System.Windows.Forms.PictureBox pbEspacio1;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}