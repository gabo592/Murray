﻿namespace Murray.Vistas
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlBarraSup = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pnlIzq = new System.Windows.Forms.Panel();
            this.gradientPanelIzq = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnSeguridad = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEmpleados = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProveedores = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProductos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCompras = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnVentas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClientes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.separadorLogo = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSeparadorMenu = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.menuTransitionMostrar = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.pnlBarraSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.pnlIzq.SuspendLayout();
            this.gradientPanelIzq.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraSup
            // 
            this.pnlBarraSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlBarraSup.Controls.Add(this.lblMenu);
            this.pnlBarraSup.Controls.Add(this.pbMenu);
            this.pnlBarraSup.Controls.Add(this.pbMinimizar);
            this.pnlBarraSup.Controls.Add(this.pbRestaurar);
            this.pnlBarraSup.Controls.Add(this.pbMaximizar);
            this.pnlBarraSup.Controls.Add(this.pbCerrar);
            this.menuTransitionMostrar.SetDecoration(this.pnlBarraSup, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlBarraSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSup.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSup.Name = "pnlBarraSup";
            this.pnlBarraSup.Size = new System.Drawing.Size(1039, 25);
            this.pnlBarraSup.TabIndex = 0;
            this.pnlBarraSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastrarVentana);
            // 
            // lblMenu
            // 
            this.menuTransitionMostrar.SetDecoration(this.lblMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(47, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(64, 25);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menú";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMenu
            // 
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTransitionMostrar.SetDecoration(this.pbMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbMenu.Image = global::Murray.Properties.Resources.menu;
            this.pbMenu.Location = new System.Drawing.Point(0, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(47, 25);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 4;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.ActivarMenu);
            // 
            // pbMinimizar
            // 
            this.menuTransitionMostrar.SetDecoration(this.pbMinimizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMinimizar.Image = global::Murray.Properties.Resources.substract;
            this.pbMinimizar.Location = new System.Drawing.Point(851, 0);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(47, 25);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 3;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.Minimizar);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.pbMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Botones_MouseMove);
            // 
            // pbRestaurar
            // 
            this.menuTransitionMostrar.SetDecoration(this.pbRestaurar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRestaurar.Image = global::Murray.Properties.Resources.squares;
            this.pbRestaurar.Location = new System.Drawing.Point(898, 0);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(47, 25);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestaurar.TabIndex = 2;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Click += new System.EventHandler(this.Restaurar);
            this.pbRestaurar.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.pbRestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Botones_MouseMove);
            // 
            // pbMaximizar
            // 
            this.menuTransitionMostrar.SetDecoration(this.pbMaximizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbMaximizar.Image = global::Murray.Properties.Resources.square;
            this.pbMaximizar.Location = new System.Drawing.Point(945, 0);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(47, 25);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 1;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.Maximizar);
            this.pbMaximizar.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.pbMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Botones_MouseMove);
            // 
            // pbCerrar
            // 
            this.menuTransitionMostrar.SetDecoration(this.pbCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = global::Murray.Properties.Resources.close;
            this.pbCerrar.Location = new System.Drawing.Point(992, 0);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(47, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.Salir);
            this.pbCerrar.MouseLeave += new System.EventHandler(this.Botones_MouseLeave);
            this.pbCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Botones_MouseMove);
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlIzq.Controls.Add(this.gradientPanelIzq);
            this.menuTransitionMostrar.SetDecoration(this.pnlIzq, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzq.Location = new System.Drawing.Point(0, 25);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(200, 491);
            this.pnlIzq.TabIndex = 1;
            // 
            // gradientPanelIzq
            // 
            this.gradientPanelIzq.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelIzq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanelIzq.BackgroundImage")));
            this.gradientPanelIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanelIzq.BorderRadius = 1;
            this.gradientPanelIzq.Controls.Add(this.btnSeguridad);
            this.gradientPanelIzq.Controls.Add(this.btnEmpleados);
            this.gradientPanelIzq.Controls.Add(this.btnProveedores);
            this.gradientPanelIzq.Controls.Add(this.btnProductos);
            this.gradientPanelIzq.Controls.Add(this.btnCompras);
            this.gradientPanelIzq.Controls.Add(this.btnVentas);
            this.gradientPanelIzq.Controls.Add(this.btnClientes);
            this.gradientPanelIzq.Controls.Add(this.separadorLogo);
            this.gradientPanelIzq.Controls.Add(this.pnlTitulo);
            this.gradientPanelIzq.Controls.Add(this.pnlSeparadorMenu);
            this.menuTransitionMostrar.SetDecoration(this.gradientPanelIzq, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.gradientPanelIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelIzq.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanelIzq.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanelIzq.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanelIzq.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.gradientPanelIzq.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelIzq.Name = "gradientPanelIzq";
            this.gradientPanelIzq.Quality = 10;
            this.gradientPanelIzq.Size = new System.Drawing.Size(200, 491);
            this.gradientPanelIzq.TabIndex = 0;
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.AllowAnimations = true;
            this.btnSeguridad.AllowMouseEffects = true;
            this.btnSeguridad.AllowToggling = false;
            this.btnSeguridad.AnimationSpeed = 200;
            this.btnSeguridad.AutoGenerateColors = false;
            this.btnSeguridad.AutoRoundBorders = false;
            this.btnSeguridad.AutoSizeLeftIcon = true;
            this.btnSeguridad.AutoSizeRightIcon = true;
            this.btnSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.btnSeguridad.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSeguridad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeguridad.BackgroundImage")));
            this.btnSeguridad.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeguridad.ButtonText = "Seguridad";
            this.btnSeguridad.ButtonTextMarginLeft = 0;
            this.btnSeguridad.ColorContrastOnClick = 45;
            this.btnSeguridad.ColorContrastOnHover = 45;
            this.btnSeguridad.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSeguridad.CustomizableEdges = borderEdges1;
            this.menuTransitionMostrar.SetDecoration(this.btnSeguridad, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSeguridad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeguridad.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSeguridad.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSeguridad.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSeguridad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.IconLeft = global::Murray.Properties.Resources.security;
            this.btnSeguridad.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSeguridad.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSeguridad.IconMarginLeft = 11;
            this.btnSeguridad.IconPadding = 5;
            this.btnSeguridad.IconRight = null;
            this.btnSeguridad.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeguridad.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSeguridad.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSeguridad.IconSize = 40;
            this.btnSeguridad.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSeguridad.IdleBorderRadius = 0;
            this.btnSeguridad.IdleBorderThickness = 0;
            this.btnSeguridad.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSeguridad.IdleIconLeftImage = global::Murray.Properties.Resources.security;
            this.btnSeguridad.IdleIconRightImage = null;
            this.btnSeguridad.IndicateFocus = false;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 288);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSeguridad.OnDisabledState.BorderRadius = 1;
            this.btnSeguridad.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeguridad.OnDisabledState.BorderThickness = 1;
            this.btnSeguridad.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSeguridad.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSeguridad.OnDisabledState.IconLeftImage = null;
            this.btnSeguridad.OnDisabledState.IconRightImage = null;
            this.btnSeguridad.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSeguridad.onHoverState.BorderRadius = 1;
            this.btnSeguridad.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeguridad.onHoverState.BorderThickness = 1;
            this.btnSeguridad.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSeguridad.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.onHoverState.IconLeftImage = null;
            this.btnSeguridad.onHoverState.IconRightImage = null;
            this.btnSeguridad.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSeguridad.OnIdleState.BorderRadius = 1;
            this.btnSeguridad.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeguridad.OnIdleState.BorderThickness = 1;
            this.btnSeguridad.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSeguridad.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.security;
            this.btnSeguridad.OnIdleState.IconRightImage = null;
            this.btnSeguridad.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSeguridad.OnPressedState.BorderRadius = 1;
            this.btnSeguridad.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeguridad.OnPressedState.BorderThickness = 1;
            this.btnSeguridad.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnSeguridad.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.OnPressedState.IconLeftImage = null;
            this.btnSeguridad.OnPressedState.IconRightImage = null;
            this.btnSeguridad.Size = new System.Drawing.Size(200, 39);
            this.btnSeguridad.TabIndex = 9;
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeguridad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeguridad.TextMarginLeft = 0;
            this.btnSeguridad.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSeguridad.UseDefaultRadiusAndThickness = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AllowAnimations = true;
            this.btnEmpleados.AllowMouseEffects = true;
            this.btnEmpleados.AllowToggling = false;
            this.btnEmpleados.AnimationSpeed = 200;
            this.btnEmpleados.AutoGenerateColors = false;
            this.btnEmpleados.AutoRoundBorders = false;
            this.btnEmpleados.AutoSizeLeftIcon = true;
            this.btnEmpleados.AutoSizeRightIcon = true;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.BackgroundImage")));
            this.btnEmpleados.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpleados.ButtonText = "Empleados";
            this.btnEmpleados.ButtonTextMarginLeft = 0;
            this.btnEmpleados.ColorContrastOnClick = 45;
            this.btnEmpleados.ColorContrastOnHover = 45;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEmpleados.CustomizableEdges = borderEdges2;
            this.menuTransitionMostrar.SetDecoration(this.btnEmpleados, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnEmpleados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmpleados.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmpleados.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnEmpleados.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconLeft = global::Murray.Properties.Resources.empleados;
            this.btnEmpleados.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpleados.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEmpleados.IconMarginLeft = 11;
            this.btnEmpleados.IconPadding = 5;
            this.btnEmpleados.IconRight = null;
            this.btnEmpleados.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpleados.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEmpleados.IconSize = 40;
            this.btnEmpleados.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnEmpleados.IdleBorderRadius = 0;
            this.btnEmpleados.IdleBorderThickness = 0;
            this.btnEmpleados.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEmpleados.IdleIconLeftImage = global::Murray.Properties.Resources.empleados;
            this.btnEmpleados.IdleIconRightImage = null;
            this.btnEmpleados.IndicateFocus = false;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 249);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmpleados.OnDisabledState.BorderRadius = 1;
            this.btnEmpleados.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpleados.OnDisabledState.BorderThickness = 1;
            this.btnEmpleados.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmpleados.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmpleados.OnDisabledState.IconLeftImage = null;
            this.btnEmpleados.OnDisabledState.IconRightImage = null;
            this.btnEmpleados.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnEmpleados.onHoverState.BorderRadius = 1;
            this.btnEmpleados.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpleados.onHoverState.BorderThickness = 1;
            this.btnEmpleados.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnEmpleados.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.onHoverState.IconLeftImage = null;
            this.btnEmpleados.onHoverState.IconRightImage = null;
            this.btnEmpleados.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnIdleState.BorderRadius = 1;
            this.btnEmpleados.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpleados.OnIdleState.BorderThickness = 1;
            this.btnEmpleados.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.empleados;
            this.btnEmpleados.OnIdleState.IconRightImage = null;
            this.btnEmpleados.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnEmpleados.OnPressedState.BorderRadius = 1;
            this.btnEmpleados.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpleados.OnPressedState.BorderThickness = 1;
            this.btnEmpleados.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnEmpleados.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.OnPressedState.IconLeftImage = null;
            this.btnEmpleados.OnPressedState.IconRightImage = null;
            this.btnEmpleados.Size = new System.Drawing.Size(200, 39);
            this.btnEmpleados.TabIndex = 8;
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmpleados.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmpleados.TextMarginLeft = 0;
            this.btnEmpleados.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEmpleados.UseDefaultRadiusAndThickness = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.AllowAnimations = true;
            this.btnProveedores.AllowMouseEffects = true;
            this.btnProveedores.AllowToggling = false;
            this.btnProveedores.AnimationSpeed = 200;
            this.btnProveedores.AutoGenerateColors = false;
            this.btnProveedores.AutoRoundBorders = false;
            this.btnProveedores.AutoSizeLeftIcon = true;
            this.btnProveedores.AutoSizeRightIcon = true;
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.BackgroundImage")));
            this.btnProveedores.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.ButtonText = "Proveedores";
            this.btnProveedores.ButtonTextMarginLeft = 0;
            this.btnProveedores.ColorContrastOnClick = 45;
            this.btnProveedores.ColorContrastOnHover = 45;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnProveedores.CustomizableEdges = borderEdges3;
            this.menuTransitionMostrar.SetDecoration(this.btnProveedores, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnProveedores.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProveedores.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProveedores.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnProveedores.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconLeft = global::Murray.Properties.Resources.delivery_truck;
            this.btnProveedores.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProveedores.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProveedores.IconMarginLeft = 11;
            this.btnProveedores.IconPadding = 5;
            this.btnProveedores.IconRight = null;
            this.btnProveedores.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProveedores.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProveedores.IconSize = 40;
            this.btnProveedores.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnProveedores.IdleBorderRadius = 0;
            this.btnProveedores.IdleBorderThickness = 0;
            this.btnProveedores.IdleFillColor = System.Drawing.Color.Empty;
            this.btnProveedores.IdleIconLeftImage = global::Murray.Properties.Resources.delivery_truck;
            this.btnProveedores.IdleIconRightImage = null;
            this.btnProveedores.IndicateFocus = false;
            this.btnProveedores.Location = new System.Drawing.Point(0, 210);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProveedores.OnDisabledState.BorderRadius = 1;
            this.btnProveedores.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.OnDisabledState.BorderThickness = 1;
            this.btnProveedores.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProveedores.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProveedores.OnDisabledState.IconLeftImage = null;
            this.btnProveedores.OnDisabledState.IconRightImage = null;
            this.btnProveedores.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProveedores.onHoverState.BorderRadius = 1;
            this.btnProveedores.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.onHoverState.BorderThickness = 1;
            this.btnProveedores.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProveedores.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.onHoverState.IconLeftImage = null;
            this.btnProveedores.onHoverState.IconRightImage = null;
            this.btnProveedores.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProveedores.OnIdleState.BorderRadius = 1;
            this.btnProveedores.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.OnIdleState.BorderThickness = 1;
            this.btnProveedores.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnProveedores.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.delivery_truck;
            this.btnProveedores.OnIdleState.IconRightImage = null;
            this.btnProveedores.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProveedores.OnPressedState.BorderRadius = 1;
            this.btnProveedores.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProveedores.OnPressedState.BorderThickness = 1;
            this.btnProveedores.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProveedores.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.OnPressedState.IconLeftImage = null;
            this.btnProveedores.OnPressedState.IconRightImage = null;
            this.btnProveedores.Size = new System.Drawing.Size(200, 39);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProveedores.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProveedores.TextMarginLeft = 0;
            this.btnProveedores.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnProveedores.UseDefaultRadiusAndThickness = true;
            // 
            // btnProductos
            // 
            this.btnProductos.AllowAnimations = true;
            this.btnProductos.AllowMouseEffects = true;
            this.btnProductos.AllowToggling = false;
            this.btnProductos.AnimationSpeed = 200;
            this.btnProductos.AutoGenerateColors = false;
            this.btnProductos.AutoRoundBorders = false;
            this.btnProductos.AutoSizeLeftIcon = true;
            this.btnProductos.AutoSizeRightIcon = true;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.BackgroundImage")));
            this.btnProductos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.ButtonText = "Productos";
            this.btnProductos.ButtonTextMarginLeft = 0;
            this.btnProductos.ColorContrastOnClick = 45;
            this.btnProductos.ColorContrastOnHover = 45;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnProductos.CustomizableEdges = borderEdges4;
            this.menuTransitionMostrar.SetDecoration(this.btnProductos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProductos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductos.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnProductos.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.IconLeft = global::Murray.Properties.Resources.box;
            this.btnProductos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnProductos.IconMarginLeft = 11;
            this.btnProductos.IconPadding = 5;
            this.btnProductos.IconRight = null;
            this.btnProductos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProductos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnProductos.IconSize = 40;
            this.btnProductos.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnProductos.IdleBorderRadius = 0;
            this.btnProductos.IdleBorderThickness = 0;
            this.btnProductos.IdleFillColor = System.Drawing.Color.Empty;
            this.btnProductos.IdleIconLeftImage = global::Murray.Properties.Resources.box;
            this.btnProductos.IdleIconRightImage = null;
            this.btnProductos.IndicateFocus = false;
            this.btnProductos.Location = new System.Drawing.Point(0, 171);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnProductos.OnDisabledState.BorderRadius = 1;
            this.btnProductos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnDisabledState.BorderThickness = 1;
            this.btnProductos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProductos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProductos.OnDisabledState.IconLeftImage = null;
            this.btnProductos.OnDisabledState.IconRightImage = null;
            this.btnProductos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProductos.onHoverState.BorderRadius = 1;
            this.btnProductos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.onHoverState.BorderThickness = 1;
            this.btnProductos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProductos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.onHoverState.IconLeftImage = null;
            this.btnProductos.onHoverState.IconRightImage = null;
            this.btnProductos.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnProductos.OnIdleState.BorderRadius = 1;
            this.btnProductos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnIdleState.BorderThickness = 1;
            this.btnProductos.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnProductos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.box;
            this.btnProductos.OnIdleState.IconRightImage = null;
            this.btnProductos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProductos.OnPressedState.BorderRadius = 1;
            this.btnProductos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProductos.OnPressedState.BorderThickness = 1;
            this.btnProductos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProductos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProductos.OnPressedState.IconLeftImage = null;
            this.btnProductos.OnPressedState.IconRightImage = null;
            this.btnProductos.Size = new System.Drawing.Size(200, 39);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProductos.TextMarginLeft = 0;
            this.btnProductos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnProductos.UseDefaultRadiusAndThickness = true;
            // 
            // btnCompras
            // 
            this.btnCompras.AllowAnimations = true;
            this.btnCompras.AllowMouseEffects = true;
            this.btnCompras.AllowToggling = false;
            this.btnCompras.AnimationSpeed = 200;
            this.btnCompras.AutoGenerateColors = false;
            this.btnCompras.AutoRoundBorders = false;
            this.btnCompras.AutoSizeLeftIcon = true;
            this.btnCompras.AutoSizeRightIcon = true;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompras.BackgroundImage")));
            this.btnCompras.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompras.ButtonText = "Compras";
            this.btnCompras.ButtonTextMarginLeft = 0;
            this.btnCompras.ColorContrastOnClick = 45;
            this.btnCompras.ColorContrastOnHover = 45;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnCompras.CustomizableEdges = borderEdges5;
            this.menuTransitionMostrar.SetDecoration(this.btnCompras, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnCompras.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompras.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCompras.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCompras.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconLeft = global::Murray.Properties.Resources.carts;
            this.btnCompras.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCompras.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCompras.IconMarginLeft = 11;
            this.btnCompras.IconPadding = 5;
            this.btnCompras.IconRight = null;
            this.btnCompras.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompras.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCompras.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCompras.IconSize = 40;
            this.btnCompras.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCompras.IdleBorderRadius = 0;
            this.btnCompras.IdleBorderThickness = 0;
            this.btnCompras.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCompras.IdleIconLeftImage = global::Murray.Properties.Resources.carts;
            this.btnCompras.IdleIconRightImage = null;
            this.btnCompras.IndicateFocus = false;
            this.btnCompras.Location = new System.Drawing.Point(0, 132);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCompras.OnDisabledState.BorderRadius = 1;
            this.btnCompras.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompras.OnDisabledState.BorderThickness = 1;
            this.btnCompras.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCompras.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCompras.OnDisabledState.IconLeftImage = null;
            this.btnCompras.OnDisabledState.IconRightImage = null;
            this.btnCompras.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCompras.onHoverState.BorderRadius = 1;
            this.btnCompras.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompras.onHoverState.BorderThickness = 1;
            this.btnCompras.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCompras.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCompras.onHoverState.IconLeftImage = null;
            this.btnCompras.onHoverState.IconRightImage = null;
            this.btnCompras.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCompras.OnIdleState.BorderRadius = 1;
            this.btnCompras.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompras.OnIdleState.BorderThickness = 1;
            this.btnCompras.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnCompras.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCompras.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.carts;
            this.btnCompras.OnIdleState.IconRightImage = null;
            this.btnCompras.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCompras.OnPressedState.BorderRadius = 1;
            this.btnCompras.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCompras.OnPressedState.BorderThickness = 1;
            this.btnCompras.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnCompras.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCompras.OnPressedState.IconLeftImage = null;
            this.btnCompras.OnPressedState.IconRightImage = null;
            this.btnCompras.Size = new System.Drawing.Size(200, 39);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompras.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCompras.TextMarginLeft = 0;
            this.btnCompras.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCompras.UseDefaultRadiusAndThickness = true;
            // 
            // btnVentas
            // 
            this.btnVentas.AllowAnimations = true;
            this.btnVentas.AllowMouseEffects = true;
            this.btnVentas.AllowToggling = false;
            this.btnVentas.AnimationSpeed = 200;
            this.btnVentas.AutoGenerateColors = false;
            this.btnVentas.AutoRoundBorders = false;
            this.btnVentas.AutoSizeLeftIcon = true;
            this.btnVentas.AutoSizeRightIcon = true;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.ButtonText = "Ventas";
            this.btnVentas.ButtonTextMarginLeft = 0;
            this.btnVentas.ColorContrastOnClick = 45;
            this.btnVentas.ColorContrastOnHover = 45;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnVentas.CustomizableEdges = borderEdges6;
            this.menuTransitionMostrar.SetDecoration(this.btnVentas, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVentas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVentas.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnVentas.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconLeft = global::Murray.Properties.Resources.ventas;
            this.btnVentas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnVentas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnVentas.IconMarginLeft = 11;
            this.btnVentas.IconPadding = 5;
            this.btnVentas.IconRight = null;
            this.btnVentas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnVentas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnVentas.IconSize = 40;
            this.btnVentas.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnVentas.IdleBorderRadius = 0;
            this.btnVentas.IdleBorderThickness = 0;
            this.btnVentas.IdleFillColor = System.Drawing.Color.Empty;
            this.btnVentas.IdleIconLeftImage = global::Murray.Properties.Resources.ventas;
            this.btnVentas.IdleIconRightImage = null;
            this.btnVentas.IndicateFocus = false;
            this.btnVentas.Location = new System.Drawing.Point(0, 93);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVentas.OnDisabledState.BorderRadius = 1;
            this.btnVentas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.OnDisabledState.BorderThickness = 1;
            this.btnVentas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVentas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVentas.OnDisabledState.IconLeftImage = null;
            this.btnVentas.OnDisabledState.IconRightImage = null;
            this.btnVentas.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVentas.onHoverState.BorderRadius = 1;
            this.btnVentas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.onHoverState.BorderThickness = 1;
            this.btnVentas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVentas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnVentas.onHoverState.IconLeftImage = null;
            this.btnVentas.onHoverState.IconRightImage = null;
            this.btnVentas.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVentas.OnIdleState.BorderRadius = 1;
            this.btnVentas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.OnIdleState.BorderThickness = 1;
            this.btnVentas.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnVentas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnVentas.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.ventas;
            this.btnVentas.OnIdleState.IconRightImage = null;
            this.btnVentas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVentas.OnPressedState.BorderRadius = 1;
            this.btnVentas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVentas.OnPressedState.BorderThickness = 1;
            this.btnVentas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnVentas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVentas.OnPressedState.IconLeftImage = null;
            this.btnVentas.OnPressedState.IconRightImage = null;
            this.btnVentas.Size = new System.Drawing.Size(200, 39);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVentas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVentas.TextMarginLeft = 0;
            this.btnVentas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnVentas.UseDefaultRadiusAndThickness = true;
            // 
            // btnClientes
            // 
            this.btnClientes.AllowAnimations = true;
            this.btnClientes.AllowMouseEffects = true;
            this.btnClientes.AllowToggling = false;
            this.btnClientes.AnimationSpeed = 200;
            this.btnClientes.AutoGenerateColors = false;
            this.btnClientes.AutoRoundBorders = false;
            this.btnClientes.AutoSizeLeftIcon = true;
            this.btnClientes.AutoSizeRightIcon = true;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.ButtonTextMarginLeft = 0;
            this.btnClientes.ColorContrastOnClick = 45;
            this.btnClientes.ColorContrastOnHover = 45;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnClientes.CustomizableEdges = borderEdges7;
            this.menuTransitionMostrar.SetDecoration(this.btnClientes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClientes.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClientes.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconLeft = global::Murray.Properties.Resources.team;
            this.btnClientes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClientes.IconMarginLeft = 11;
            this.btnClientes.IconPadding = 5;
            this.btnClientes.IconRight = null;
            this.btnClientes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClientes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClientes.IconSize = 40;
            this.btnClientes.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClientes.IdleBorderRadius = 0;
            this.btnClientes.IdleBorderThickness = 0;
            this.btnClientes.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClientes.IdleIconLeftImage = global::Murray.Properties.Resources.team;
            this.btnClientes.IdleIconRightImage = null;
            this.btnClientes.IndicateFocus = false;
            this.btnClientes.Location = new System.Drawing.Point(0, 54);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClientes.OnDisabledState.BorderRadius = 1;
            this.btnClientes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnDisabledState.BorderThickness = 1;
            this.btnClientes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClientes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClientes.OnDisabledState.IconLeftImage = null;
            this.btnClientes.OnDisabledState.IconRightImage = null;
            this.btnClientes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnClientes.onHoverState.BorderRadius = 1;
            this.btnClientes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.onHoverState.BorderThickness = 1;
            this.btnClientes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnClientes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.onHoverState.IconLeftImage = null;
            this.btnClientes.onHoverState.IconRightImage = null;
            this.btnClientes.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnIdleState.BorderRadius = 1;
            this.btnClientes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnIdleState.BorderThickness = 1;
            this.btnClientes.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.OnIdleState.IconLeftImage = global::Murray.Properties.Resources.team;
            this.btnClientes.OnIdleState.IconRightImage = null;
            this.btnClientes.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnClientes.OnPressedState.BorderRadius = 1;
            this.btnClientes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClientes.OnPressedState.BorderThickness = 1;
            this.btnClientes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnClientes.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClientes.OnPressedState.IconLeftImage = null;
            this.btnClientes.OnPressedState.IconRightImage = null;
            this.btnClientes.Size = new System.Drawing.Size(200, 39);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClientes.TextMarginLeft = 0;
            this.btnClientes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClientes.UseDefaultRadiusAndThickness = true;
            // 
            // separadorLogo
            // 
            this.separadorLogo.BackColor = System.Drawing.Color.Transparent;
            this.separadorLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separadorLogo.BackgroundImage")));
            this.separadorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.separadorLogo.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.menuTransitionMostrar.SetDecoration(this.separadorLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.separadorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.separadorLogo.LineColor = System.Drawing.Color.Silver;
            this.separadorLogo.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.separadorLogo.LineThickness = 1;
            this.separadorLogo.Location = new System.Drawing.Point(0, 46);
            this.separadorLogo.Name = "separadorLogo";
            this.separadorLogo.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.separadorLogo.Size = new System.Drawing.Size(200, 8);
            this.separadorLogo.TabIndex = 2;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.pbLogo);
            this.menuTransitionMostrar.SetDecoration(this.pnlTitulo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 11);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(200, 35);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.menuTransitionMostrar.SetDecoration(this.lblTitulo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(47, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Murray";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLogo
            // 
            this.menuTransitionMostrar.SetDecoration(this.pbLogo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::Murray.Properties.Resources.atom;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(47, 35);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlSeparadorMenu
            // 
            this.menuTransitionMostrar.SetDecoration(this.pnlSeparadorMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlSeparadorMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparadorMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSeparadorMenu.Name = "pnlSeparadorMenu";
            this.pnlSeparadorMenu.Size = new System.Drawing.Size(200, 11);
            this.pnlSeparadorMenu.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.menuTransitionMostrar.SetDecoration(this.pnlPrincipal, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 25);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(839, 491);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // menuTransitionMostrar
            // 
            this.menuTransitionMostrar.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuTransitionMostrar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menuTransitionMostrar.DefaultAnimation = animation1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 516);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlIzq);
            this.Controls.Add(this.pnlBarraSup);
            this.menuTransitionMostrar.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.pnlBarraSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.pnlIzq.ResumeLayout(false);
            this.gradientPanelIzq.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSup;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlIzq;
        private System.Windows.Forms.Panel pnlPrincipal;
        private Bunifu.UI.WinForms.BunifuGradientPanel gradientPanelIzq;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlSeparadorMenu;
        private Bunifu.UI.WinForms.BunifuSeparator separadorLogo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClientes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVentas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCompras;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProductos;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProveedores;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEmpleados;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSeguridad;
        private Bunifu.UI.WinForms.BunifuTransition menuTransitionMostrar;
    }
}