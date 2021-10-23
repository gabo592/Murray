
namespace Murray.Presentacion.Productos
{
    partial class FrmSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccion));
            this.pnlVerTodos = new System.Windows.Forms.Panel();
            this.lblVerTodos = new System.Windows.Forms.Label();
            this.pbVerTodos = new System.Windows.Forms.PictureBox();
            this.pnlSepVerTodos = new System.Windows.Forms.Panel();
            this.pnlVerCategorias = new System.Windows.Forms.Panel();
            this.lblVerCategorias = new System.Windows.Forms.Label();
            this.pbVerCategorias = new System.Windows.Forms.PictureBox();
            this.pnlSepVerCategori = new System.Windows.Forms.Panel();
            this.pnlVerTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerTodos)).BeginInit();
            this.pnlVerCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVerTodos
            // 
            this.pnlVerTodos.Controls.Add(this.lblVerTodos);
            this.pnlVerTodos.Controls.Add(this.pbVerTodos);
            this.pnlVerTodos.Controls.Add(this.pnlSepVerTodos);
            this.pnlVerTodos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVerTodos.Location = new System.Drawing.Point(0, 0);
            this.pnlVerTodos.Name = "pnlVerTodos";
            this.pnlVerTodos.Size = new System.Drawing.Size(217, 265);
            this.pnlVerTodos.TabIndex = 0;
            // 
            // lblVerTodos
            // 
            this.lblVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVerTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.lblVerTodos.Location = new System.Drawing.Point(0, 155);
            this.lblVerTodos.Name = "lblVerTodos";
            this.lblVerTodos.Size = new System.Drawing.Size(217, 110);
            this.lblVerTodos.TabIndex = 2;
            this.lblVerTodos.Text = "Ver Todos";
            this.lblVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVerTodos.Click += new System.EventHandler(this.VerTodos_Click);
            // 
            // pbVerTodos
            // 
            this.pbVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVerTodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbVerTodos.Image = global::Murray.Properties.Resources.magnifying_glass;
            this.pbVerTodos.Location = new System.Drawing.Point(0, 15);
            this.pbVerTodos.Name = "pbVerTodos";
            this.pbVerTodos.Size = new System.Drawing.Size(217, 140);
            this.pbVerTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerTodos.TabIndex = 1;
            this.pbVerTodos.TabStop = false;
            this.pbVerTodos.Click += new System.EventHandler(this.VerTodos_Click);
            // 
            // pnlSepVerTodos
            // 
            this.pnlSepVerTodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSepVerTodos.Location = new System.Drawing.Point(0, 0);
            this.pnlSepVerTodos.Name = "pnlSepVerTodos";
            this.pnlSepVerTodos.Size = new System.Drawing.Size(217, 15);
            this.pnlSepVerTodos.TabIndex = 0;
            // 
            // pnlVerCategorias
            // 
            this.pnlVerCategorias.Controls.Add(this.lblVerCategorias);
            this.pnlVerCategorias.Controls.Add(this.pbVerCategorias);
            this.pnlVerCategorias.Controls.Add(this.pnlSepVerCategori);
            this.pnlVerCategorias.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVerCategorias.Location = new System.Drawing.Point(211, 0);
            this.pnlVerCategorias.Name = "pnlVerCategorias";
            this.pnlVerCategorias.Size = new System.Drawing.Size(214, 265);
            this.pnlVerCategorias.TabIndex = 1;
            // 
            // lblVerCategorias
            // 
            this.lblVerCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVerCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(131)))));
            this.lblVerCategorias.Location = new System.Drawing.Point(0, 155);
            this.lblVerCategorias.Name = "lblVerCategorias";
            this.lblVerCategorias.Size = new System.Drawing.Size(214, 110);
            this.lblVerCategorias.TabIndex = 2;
            this.lblVerCategorias.Text = "Ver Categorías";
            this.lblVerCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVerCategorias.Click += new System.EventHandler(this.VerCategorias_Click);
            // 
            // pbVerCategorias
            // 
            this.pbVerCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVerCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbVerCategorias.Image = global::Murray.Properties.Resources.categories;
            this.pbVerCategorias.Location = new System.Drawing.Point(0, 15);
            this.pbVerCategorias.Name = "pbVerCategorias";
            this.pbVerCategorias.Size = new System.Drawing.Size(214, 140);
            this.pbVerCategorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerCategorias.TabIndex = 1;
            this.pbVerCategorias.TabStop = false;
            this.pbVerCategorias.Click += new System.EventHandler(this.VerCategorias_Click);
            // 
            // pnlSepVerCategori
            // 
            this.pnlSepVerCategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSepVerCategori.Location = new System.Drawing.Point(0, 0);
            this.pnlSepVerCategori.Name = "pnlSepVerCategori";
            this.pnlSepVerCategori.Size = new System.Drawing.Size(214, 15);
            this.pnlSepVerCategori.TabIndex = 0;
            // 
            // FrmSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 265);
            this.Controls.Add(this.pnlVerCategorias);
            this.Controls.Add(this.pnlVerTodos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección";
            this.pnlVerTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVerTodos)).EndInit();
            this.pnlVerCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVerCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVerTodos;
        private System.Windows.Forms.Panel pnlVerCategorias;
        private System.Windows.Forms.Label lblVerTodos;
        private System.Windows.Forms.PictureBox pbVerTodos;
        private System.Windows.Forms.Panel pnlSepVerTodos;
        private System.Windows.Forms.Label lblVerCategorias;
        private System.Windows.Forms.PictureBox pbVerCategorias;
        private System.Windows.Forms.Panel pnlSepVerCategori;
    }
}