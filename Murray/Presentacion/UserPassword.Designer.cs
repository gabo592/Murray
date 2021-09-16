
namespace Murray.Presentacion
{
    partial class UserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPassword));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pbMostrarPass = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(58)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(590, 76);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Introduzca la contraseña";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(12, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(566, 31);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // pbMostrarPass
            // 
            this.pbMostrarPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMostrarPass.Image = global::Murray.Properties.Resources.eye;
            this.pbMostrarPass.Location = new System.Drawing.Point(248, 116);
            this.pbMostrarPass.Name = "pbMostrarPass";
            this.pbMostrarPass.Size = new System.Drawing.Size(100, 50);
            this.pbMostrarPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarPass.TabIndex = 2;
            this.pbMostrarPass.TabStop = false;
            this.pbMostrarPass.Click += new System.EventHandler(this.PbMostrarPass_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(104, 192);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(410, 25);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "La contraseña no puede quedar vacía";
            // 
            // UserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 226);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pbMostrarPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pbMostrarPass;
        private System.Windows.Forms.Label lblMensaje;
    }
}