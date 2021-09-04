
namespace Murray
{
    partial class FrmBienvenida
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenida));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbIniciarSesion = new System.Windows.Forms.PictureBox();
            this.pbCrearCuenta = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(224)))), ((int)(((byte)(136)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(489, 82);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "¡Bienvenido a Murray!";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIniciarSesion
            // 
            this.pbIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIniciarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbIniciarSesion.Image = global::Murray.Properties.Resources.enter;
            this.pbIniciarSesion.Location = new System.Drawing.Point(241, 287);
            this.pbIniciarSesion.Name = "pbIniciarSesion";
            this.pbIniciarSesion.Size = new System.Drawing.Size(248, 141);
            this.pbIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIniciarSesion.TabIndex = 3;
            this.pbIniciarSesion.TabStop = false;
            // 
            // pbCrearCuenta
            // 
            this.pbCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCrearCuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCrearCuenta.Image = global::Murray.Properties.Resources.user;
            this.pbCrearCuenta.Location = new System.Drawing.Point(0, 287);
            this.pbCrearCuenta.Name = "pbCrearCuenta";
            this.pbCrearCuenta.Size = new System.Drawing.Size(239, 141);
            this.pbCrearCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrearCuenta.TabIndex = 2;
            this.pbCrearCuenta.TabStop = false;
            this.pbCrearCuenta.Click += new System.EventHandler(this.PbCrearCuenta_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImagen.Image = global::Murray.Properties.Resources.atom;
            this.pbImagen.Location = new System.Drawing.Point(0, 82);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(489, 205);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 428);
            this.Controls.Add(this.pbIniciarSesion);
            this.Controls.Add(this.pbCrearCuenta);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Murray - Bienvenida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBienvenida_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbCrearCuenta;
        private System.Windows.Forms.PictureBox pbIniciarSesion;
    }
}

