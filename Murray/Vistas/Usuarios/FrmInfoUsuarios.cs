﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murray.Vistas.Usuarios
{
    public partial class FrmInfoUsuarios : Form
    {
        public FrmInfoUsuarios()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, EventArgs args)
        {
            Close();
        }
    }
}
