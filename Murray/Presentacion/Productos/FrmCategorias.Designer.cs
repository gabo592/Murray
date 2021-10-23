
namespace Murray.Presentacion.Productos
{
    partial class FrmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.pnlBarraSup = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pbAgregarCategoria = new System.Windows.Forms.PictureBox();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.pnlSepBarraPrincipal = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBarraSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraSup
            // 
            this.pnlBarraSup.Controls.Add(this.txtBuscarCategoria);
            this.pnlBarraSup.Controls.Add(this.lblAgregarCategoria);
            this.pnlBarraSup.Controls.Add(this.pbAgregarCategoria);
            this.pnlBarraSup.Controls.Add(this.lblBuscar);
            this.pnlBarraSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSup.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSup.Name = "pnlBarraSup";
            this.pnlBarraSup.Size = new System.Drawing.Size(843, 24);
            this.pnlBarraSup.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(0, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(82, 24);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAgregarCategoria
            // 
            this.pbAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAgregarCategoria.Image = global::Murray.Properties.Resources.plus;
            this.pbAgregarCategoria.Location = new System.Drawing.Point(792, 0);
            this.pbAgregarCategoria.Name = "pbAgregarCategoria";
            this.pbAgregarCategoria.Size = new System.Drawing.Size(51, 24);
            this.pbAgregarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregarCategoria.TabIndex = 1;
            this.pbAgregarCategoria.TabStop = false;
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(39)))));
            this.lblAgregarCategoria.Location = new System.Drawing.Point(647, 0);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(145, 24);
            this.lblAgregarCategoria.TabIndex = 2;
            this.lblAgregarCategoria.Text = "Agregar Categoría";
            this.lblAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(82, 0);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(565, 22);
            this.txtBuscarCategoria.TabIndex = 3;
            // 
            // pnlSepBarraPrincipal
            // 
            this.pnlSepBarraPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSepBarraPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlSepBarraPrincipal.Name = "pnlSepBarraPrincipal";
            this.pnlSepBarraPrincipal.Size = new System.Drawing.Size(843, 16);
            this.pnlSepBarraPrincipal.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 40);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(843, 356);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 396);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSepBarraPrincipal);
            this.Controls.Add(this.pnlBarraSup);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.pnlBarraSup.ResumeLayout(false);
            this.pnlBarraSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSup;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.PictureBox pbAgregarCategoria;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel pnlSepBarraPrincipal;
        private System.Windows.Forms.FlowLayoutPanel pnlPrincipal;
    }
}