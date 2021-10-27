
namespace Murray.Presentacion
{
    partial class FrmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarSesion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlParteSuperior = new System.Windows.Forms.Panel();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlParteSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(58)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 100);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "¿Quién está iniciando sesión?";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlParteSuperior
            // 
            this.pnlParteSuperior.Controls.Add(this.pbRegresar);
            this.pnlParteSuperior.Controls.Add(this.lblTitulo);
            this.pnlParteSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlParteSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlParteSuperior.Name = "pnlParteSuperior";
            this.pnlParteSuperior.Size = new System.Drawing.Size(800, 100);
            this.pnlParteSuperior.TabIndex = 1;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegresar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbRegresar.Image = global::Murray.Properties.Resources.previous;
            this.pbRegresar.Location = new System.Drawing.Point(0, 0);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(47, 100);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegresar.TabIndex = 1;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.PbRegresar_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 100);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 350);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlParteSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIniciarSesion_FormClosing);
            this.Load += new System.EventHandler(this.FrmIniciarSesion_Load);
            this.pnlParteSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlParteSuperior;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.FlowLayoutPanel pnlPrincipal;

        public System.Windows.Forms.FlowLayoutPanel PnlPrincipal { get => pnlPrincipal; }
    }
}