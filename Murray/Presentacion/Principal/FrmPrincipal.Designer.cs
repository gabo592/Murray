
namespace Murray.Presentacion.Principal
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlBarraSup = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbProductos = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbConfig = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.pnlBarraSup.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(736, 57);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Murray";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBarraSup
            // 
            this.pnlBarraSup.Controls.Add(this.pbLogo);
            this.pnlBarraSup.Controls.Add(this.lblLogo);
            this.pnlBarraSup.Controls.Add(this.pbConfig);
            this.pnlBarraSup.Controls.Add(this.pbUsuario);
            this.pnlBarraSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSup.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSup.Name = "pnlBarraSup";
            this.pnlBarraSup.Size = new System.Drawing.Size(839, 57);
            this.pnlBarraSup.TabIndex = 3;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoScroll = true;
            this.pnlPrincipal.Controls.Add(this.pnlClientes);
            this.pnlPrincipal.Controls.Add(this.pnlProductos);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 57);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(839, 357);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.lblClientes);
            this.pnlClientes.Controls.Add(this.pbClientes);
            this.pnlClientes.Location = new System.Drawing.Point(3, 3);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(171, 191);
            this.pnlClientes.TabIndex = 0;
            // 
            // lblClientes
            // 
            this.lblClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(0, 116);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(171, 75);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.lblProductos);
            this.pnlProductos.Controls.Add(this.pbProductos);
            this.pnlProductos.Location = new System.Drawing.Point(180, 3);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(171, 191);
            this.pnlProductos.TabIndex = 1;
            // 
            // pbClientes
            // 
            this.pbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbClientes.Image = global::Murray.Properties.Resources.team;
            this.pbClientes.Location = new System.Drawing.Point(0, 0);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(171, 116);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClientes.TabIndex = 0;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.CargarFrame);
            // 
            // pbProductos
            // 
            this.pbProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbProductos.Image = global::Murray.Properties.Resources.box;
            this.pbProductos.Location = new System.Drawing.Point(0, 0);
            this.pbProductos.Name = "pbProductos";
            this.pbProductos.Size = new System.Drawing.Size(171, 116);
            this.pbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductos.TabIndex = 0;
            this.pbProductos.TabStop = false;
            this.pbProductos.Click += new System.EventHandler(this.CargarFrame);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::Murray.Properties.Resources.atom;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(77, 57);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbConfig
            // 
            this.pbConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbConfig.Image = global::Murray.Properties.Resources.settings;
            this.pbConfig.Location = new System.Drawing.Point(736, 0);
            this.pbConfig.Name = "pbConfig";
            this.pbConfig.Size = new System.Drawing.Size(38, 57);
            this.pbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfig.TabIndex = 2;
            this.pbConfig.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbUsuario.Location = new System.Drawing.Point(774, 0);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(65, 57);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            // 
            // lblProductos
            // 
            this.lblProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(0, 116);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(171, 75);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Productos";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 414);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBarraSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlBarraSup.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbConfig;
        private System.Windows.Forms.Panel pnlBarraSup;
        private System.Windows.Forms.FlowLayoutPanel pnlPrincipal;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.PictureBox pbProductos;
        private System.Windows.Forms.Label lblProductos;
    }
}