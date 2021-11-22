namespace Murray.Vistas.Usuarios
{
    partial class FrmInfoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoUsuarios));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pbImagenUsuario = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtContraseña = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cmbRoles = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnAgregarUsuario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnModificarUsuario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtEmpleados = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvEmpleados = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnModificarUsuario);
            this.pnlBotones.Controls.Add(this.btnAgregarUsuario);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 234);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(599, 55);
            this.pnlBotones.TabIndex = 0;
            // 
            // pbImagenUsuario
            // 
            this.pbImagenUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbImagenUsuario.Image = global::Murray.Properties.Resources.user;
            this.pbImagenUsuario.Location = new System.Drawing.Point(0, 0);
            this.pbImagenUsuario.Name = "pbImagenUsuario";
            this.pbImagenUsuario.Size = new System.Drawing.Size(100, 234);
            this.pbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenUsuario.TabIndex = 1;
            this.pbImagenUsuario.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.dgvEmpleados);
            this.pnlPrincipal.Controls.Add(this.txtEmpleados);
            this.pnlPrincipal.Controls.Add(this.cmbRoles);
            this.pnlPrincipal.Controls.Add(this.txtContraseña);
            this.pnlPrincipal.Controls.Add(this.lblEmpleado);
            this.pnlPrincipal.Controls.Add(this.lblRol);
            this.pnlPrincipal.Controls.Add(this.lblContraseña);
            this.pnlPrincipal.Controls.Add(this.txtNombreUsuario);
            this.pnlPrincipal.Controls.Add(this.lblNombreUsuario);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(100, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(499, 234);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(6, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(214, 25);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AcceptsReturn = false;
            this.txtNombreUsuario.AcceptsTab = false;
            this.txtNombreUsuario.AnimationSpeed = 200;
            this.txtNombreUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreUsuario.AutoSizeHeight = true;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNombreUsuario.BackgroundImage")));
            this.txtNombreUsuario.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombreUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNombreUsuario.BorderColorHover = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombreUsuario.BorderRadius = 1;
            this.txtNombreUsuario.BorderThickness = 1;
            this.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.DefaultText = "";
            this.txtNombreUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.txtNombreUsuario.HideSelection = true;
            this.txtNombreUsuario.IconLeft = null;
            this.txtNombreUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.IconPadding = 10;
            this.txtNombreUsuario.IconRight = null;
            this.txtNombreUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.Lines = new string[0];
            this.txtNombreUsuario.Location = new System.Drawing.Point(227, 12);
            this.txtNombreUsuario.MaxLength = 32767;
            this.txtNombreUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNombreUsuario.Modified = false;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreUsuario.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNombreUsuario.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.White;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreUsuario.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties16.ForeColor = System.Drawing.Color.White;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNombreUsuario.OnIdleState = stateProperties16;
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNombreUsuario.PlaceholderText = "Enter text";
            this.txtNombreUsuario.ReadOnly = false;
            this.txtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.ShortcutsEnabled = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(260, 41);
            this.txtNombreUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreUsuario.TextMarginBottom = 0;
            this.txtNombreUsuario.TextMarginLeft = 3;
            this.txtNombreUsuario.TextMarginTop = 1;
            this.txtNombreUsuario.TextPlaceholder = "Enter text";
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            this.txtNombreUsuario.WordWrap = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(6, 71);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(133, 25);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(6, 122);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(47, 25);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(3, 169);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(116, 25);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtContraseña
            // 
            this.txtContraseña.AcceptsReturn = false;
            this.txtContraseña.AcceptsTab = false;
            this.txtContraseña.AnimationSpeed = 200;
            this.txtContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContraseña.AutoSizeHeight = true;
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtContraseña.BackgroundImage")));
            this.txtContraseña.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtContraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContraseña.BorderColorHover = System.Drawing.Color.White;
            this.txtContraseña.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtContraseña.BorderRadius = 1;
            this.txtContraseña.BorderThickness = 1;
            this.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.HideSelection = true;
            this.txtContraseña.IconLeft = null;
            this.txtContraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.IconPadding = 10;
            this.txtContraseña.IconRight = null;
            this.txtContraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.Lines = new string[0];
            this.txtContraseña.Location = new System.Drawing.Point(227, 59);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtContraseña.Modified = false;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.White;
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties20.ForeColor = System.Drawing.Color.White;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtContraseña.OnIdleState = stateProperties20;
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(3);
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.PlaceholderText = "Enter text";
            this.txtContraseña.ReadOnly = false;
            this.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(260, 41);
            this.txtContraseña.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContraseña.TextMarginBottom = 0;
            this.txtContraseña.TextMarginLeft = 3;
            this.txtContraseña.TextMarginTop = 1;
            this.txtContraseña.TextPlaceholder = "Enter text";
            this.txtContraseña.UseSystemPasswordChar = false;
            this.txtContraseña.WordWrap = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoles.BackgroundColor = System.Drawing.Color.White;
            this.cmbRoles.BorderColor = System.Drawing.Color.Silver;
            this.cmbRoles.BorderRadius = 1;
            this.cmbRoles.Color = System.Drawing.Color.Silver;
            this.cmbRoles.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbRoles.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRoles.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbRoles.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbRoles.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbRoles.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoles.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbRoles.FillDropDown = true;
            this.cmbRoles.FillIndicator = false;
            this.cmbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.ForeColor = System.Drawing.Color.Black;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Icon = null;
            this.cmbRoles.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbRoles.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbRoles.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbRoles.IndicatorThickness = 2;
            this.cmbRoles.IsDropdownOpened = false;
            this.cmbRoles.ItemBackColor = System.Drawing.Color.White;
            this.cmbRoles.ItemBorderColor = System.Drawing.Color.White;
            this.cmbRoles.ItemForeColor = System.Drawing.Color.Black;
            this.cmbRoles.ItemHeight = 26;
            this.cmbRoles.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbRoles.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbRoles.ItemTopMargin = 3;
            this.cmbRoles.Location = new System.Drawing.Point(227, 115);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(260, 32);
            this.cmbRoles.TabIndex = 6;
            this.cmbRoles.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbRoles.TextLeftMargin = 5;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AllowAnimations = true;
            this.btnAgregarUsuario.AllowMouseEffects = true;
            this.btnAgregarUsuario.AllowToggling = false;
            this.btnAgregarUsuario.AnimationSpeed = 200;
            this.btnAgregarUsuario.AutoGenerateColors = false;
            this.btnAgregarUsuario.AutoRoundBorders = false;
            this.btnAgregarUsuario.AutoSizeLeftIcon = true;
            this.btnAgregarUsuario.AutoSizeRightIcon = true;
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAgregarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.BackgroundImage")));
            this.btnAgregarUsuario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.ButtonText = "Agregar";
            this.btnAgregarUsuario.ButtonTextMarginLeft = 0;
            this.btnAgregarUsuario.ColorContrastOnClick = 45;
            this.btnAgregarUsuario.ColorContrastOnHover = 45;
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnAgregarUsuario.CustomizableEdges = borderEdges4;
            this.btnAgregarUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarUsuario.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAgregarUsuario.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregarUsuario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.IconLeft = null;
            this.btnAgregarUsuario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarUsuario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarUsuario.IconMarginLeft = 11;
            this.btnAgregarUsuario.IconPadding = 10;
            this.btnAgregarUsuario.IconRight = null;
            this.btnAgregarUsuario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsuario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarUsuario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarUsuario.IconSize = 25;
            this.btnAgregarUsuario.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAgregarUsuario.IdleBorderRadius = 0;
            this.btnAgregarUsuario.IdleBorderThickness = 0;
            this.btnAgregarUsuario.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAgregarUsuario.IdleIconLeftImage = null;
            this.btnAgregarUsuario.IdleIconRightImage = null;
            this.btnAgregarUsuario.IndicateFocus = false;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(466, 0);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarUsuario.OnDisabledState.BorderRadius = 1;
            this.btnAgregarUsuario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.OnDisabledState.BorderThickness = 1;
            this.btnAgregarUsuario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarUsuario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarUsuario.OnDisabledState.IconLeftImage = null;
            this.btnAgregarUsuario.OnDisabledState.IconRightImage = null;
            this.btnAgregarUsuario.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAgregarUsuario.onHoverState.BorderRadius = 1;
            this.btnAgregarUsuario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.onHoverState.BorderThickness = 1;
            this.btnAgregarUsuario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAgregarUsuario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.onHoverState.IconLeftImage = null;
            this.btnAgregarUsuario.onHoverState.IconRightImage = null;
            this.btnAgregarUsuario.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAgregarUsuario.OnIdleState.BorderRadius = 1;
            this.btnAgregarUsuario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.OnIdleState.BorderThickness = 1;
            this.btnAgregarUsuario.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnAgregarUsuario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.OnIdleState.IconLeftImage = null;
            this.btnAgregarUsuario.OnIdleState.IconRightImage = null;
            this.btnAgregarUsuario.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAgregarUsuario.OnPressedState.BorderRadius = 1;
            this.btnAgregarUsuario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.OnPressedState.BorderThickness = 1;
            this.btnAgregarUsuario.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnAgregarUsuario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.OnPressedState.IconLeftImage = null;
            this.btnAgregarUsuario.OnPressedState.IconRightImage = null;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(133, 55);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarUsuario.TextMarginLeft = 0;
            this.btnAgregarUsuario.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregarUsuario.UseDefaultRadiusAndThickness = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.AllowAnimations = true;
            this.btnModificarUsuario.AllowMouseEffects = true;
            this.btnModificarUsuario.AllowToggling = false;
            this.btnModificarUsuario.AnimationSpeed = 200;
            this.btnModificarUsuario.AutoGenerateColors = false;
            this.btnModificarUsuario.AutoRoundBorders = false;
            this.btnModificarUsuario.AutoSizeLeftIcon = true;
            this.btnModificarUsuario.AutoSizeRightIcon = true;
            this.btnModificarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarUsuario.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnModificarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarUsuario.BackgroundImage")));
            this.btnModificarUsuario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarUsuario.ButtonText = "Actualizar";
            this.btnModificarUsuario.ButtonTextMarginLeft = 0;
            this.btnModificarUsuario.ColorContrastOnClick = 45;
            this.btnModificarUsuario.ColorContrastOnHover = 45;
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnModificarUsuario.CustomizableEdges = borderEdges5;
            this.btnModificarUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificarUsuario.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificarUsuario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.IconLeft = null;
            this.btnModificarUsuario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarUsuario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModificarUsuario.IconMarginLeft = 11;
            this.btnModificarUsuario.IconPadding = 10;
            this.btnModificarUsuario.IconRight = null;
            this.btnModificarUsuario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUsuario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarUsuario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModificarUsuario.IconSize = 25;
            this.btnModificarUsuario.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.IdleBorderRadius = 0;
            this.btnModificarUsuario.IdleBorderThickness = 0;
            this.btnModificarUsuario.IdleFillColor = System.Drawing.Color.Empty;
            this.btnModificarUsuario.IdleIconLeftImage = null;
            this.btnModificarUsuario.IdleIconRightImage = null;
            this.btnModificarUsuario.IndicateFocus = false;
            this.btnModificarUsuario.Location = new System.Drawing.Point(333, 0);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificarUsuario.OnDisabledState.BorderRadius = 1;
            this.btnModificarUsuario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarUsuario.OnDisabledState.BorderThickness = 1;
            this.btnModificarUsuario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificarUsuario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificarUsuario.OnDisabledState.IconLeftImage = null;
            this.btnModificarUsuario.OnDisabledState.IconRightImage = null;
            this.btnModificarUsuario.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarUsuario.onHoverState.BorderRadius = 1;
            this.btnModificarUsuario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarUsuario.onHoverState.BorderThickness = 1;
            this.btnModificarUsuario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarUsuario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.onHoverState.IconLeftImage = null;
            this.btnModificarUsuario.onHoverState.IconRightImage = null;
            this.btnModificarUsuario.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnModificarUsuario.OnIdleState.BorderRadius = 1;
            this.btnModificarUsuario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarUsuario.OnIdleState.BorderThickness = 1;
            this.btnModificarUsuario.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnModificarUsuario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.OnIdleState.IconLeftImage = null;
            this.btnModificarUsuario.OnIdleState.IconRightImage = null;
            this.btnModificarUsuario.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarUsuario.OnPressedState.BorderRadius = 1;
            this.btnModificarUsuario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificarUsuario.OnPressedState.BorderThickness = 1;
            this.btnModificarUsuario.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnModificarUsuario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.OnPressedState.IconLeftImage = null;
            this.btnModificarUsuario.OnPressedState.IconRightImage = null;
            this.btnModificarUsuario.Size = new System.Drawing.Size(133, 55);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificarUsuario.TextMarginLeft = 0;
            this.btnModificarUsuario.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModificarUsuario.UseDefaultRadiusAndThickness = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.AnimationSpeed = 200;
            this.btnCancelar.AutoGenerateColors = false;
            this.btnCancelar.AutoRoundBorders = false;
            this.btnCancelar.AutoSizeLeftIcon = true;
            this.btnCancelar.AutoSizeRightIcon = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges6;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconLeft = null;
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRight = null;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCancelar.IdleBorderRadius = 0;
            this.btnCancelar.IdleBorderThickness = 0;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = false;
            this.btnCancelar.Location = new System.Drawing.Point(200, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 1;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 1;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnCancelar.onHoverState.BorderRadius = 1;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 1;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCancelar.OnIdleState.BorderRadius = 1;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 1;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnCancelar.OnPressedState.BorderRadius = 1;
            this.btnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnPressedState.BorderThickness = 1;
            this.btnCancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.btnCancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.IconLeftImage = null;
            this.btnCancelar.OnPressedState.IconRightImage = null;
            this.btnCancelar.Size = new System.Drawing.Size(133, 55);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            // 
            // txtEmpleados
            // 
            this.txtEmpleados.AcceptsReturn = false;
            this.txtEmpleados.AcceptsTab = false;
            this.txtEmpleados.AnimationSpeed = 200;
            this.txtEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmpleados.AutoSizeHeight = true;
            this.txtEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.txtEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmpleados.BackgroundImage")));
            this.txtEmpleados.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtEmpleados.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmpleados.BorderColorHover = System.Drawing.Color.White;
            this.txtEmpleados.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtEmpleados.BorderRadius = 1;
            this.txtEmpleados.BorderThickness = 1;
            this.txtEmpleados.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmpleados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleados.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleados.DefaultText = "";
            this.txtEmpleados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtEmpleados.ForeColor = System.Drawing.Color.White;
            this.txtEmpleados.HideSelection = true;
            this.txtEmpleados.IconLeft = null;
            this.txtEmpleados.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleados.IconPadding = 10;
            this.txtEmpleados.IconRight = null;
            this.txtEmpleados.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleados.Lines = new string[0];
            this.txtEmpleados.Location = new System.Drawing.Point(227, 169);
            this.txtEmpleados.MaxLength = 32767;
            this.txtEmpleados.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmpleados.Modified = false;
            this.txtEmpleados.Multiline = false;
            this.txtEmpleados.Name = "txtEmpleados";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmpleados.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmpleados.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.White;
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmpleados.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties24.ForeColor = System.Drawing.Color.White;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmpleados.OnIdleState = stateProperties24;
            this.txtEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmpleados.PasswordChar = '\0';
            this.txtEmpleados.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmpleados.PlaceholderText = "Enter text";
            this.txtEmpleados.ReadOnly = false;
            this.txtEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpleados.SelectedText = "";
            this.txtEmpleados.SelectionLength = 0;
            this.txtEmpleados.SelectionStart = 0;
            this.txtEmpleados.ShortcutsEnabled = true;
            this.txtEmpleados.Size = new System.Drawing.Size(260, 41);
            this.txtEmpleados.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmpleados.TabIndex = 7;
            this.txtEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpleados.TextMarginBottom = 0;
            this.txtEmpleados.TextMarginLeft = 3;
            this.txtEmpleados.TextMarginTop = 1;
            this.txtEmpleados.TextPlaceholder = "Enter text";
            this.txtEmpleados.UseSystemPasswordChar = false;
            this.txtEmpleados.WordWrap = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowCustomTheming = false;
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmpleados.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmpleados.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEmpleados.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.Name = null;
            this.dgvEmpleados.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEmpleados.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmpleados.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEmpleados.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEmpleados.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEmpleados.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.Location = new System.Drawing.Point(8, 28);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowTemplate.Height = 40;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(479, 149);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvEmpleados.Visible = false;
            // 
            // FrmInfoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(599, 289);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pbImagenUsuario);
            this.Controls.Add(this.pnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInfoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Usuarios";
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.PictureBox pbImagenUsuario;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Bunifu.UI.WinForms.BunifuDropdown cmbRoles;
        private Bunifu.UI.WinForms.BunifuTextBox txtContraseña;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContraseña;
        private Bunifu.UI.WinForms.BunifuTextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarUsuario;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnModificarUsuario;
        private Bunifu.UI.WinForms.BunifuTextBox txtEmpleados;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEmpleados;
    }
}