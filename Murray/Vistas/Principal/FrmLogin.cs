﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murray.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void Login()
        {
            //Validaciones
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            Close();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
