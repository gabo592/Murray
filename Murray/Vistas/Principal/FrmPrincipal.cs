﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Murray.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            pbRestaurar.Visible = false;
            pnlIzq.Visible = false;
        }

        #region Metodos externos
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWind, int wMsg, int wParam, int lParam);
        #endregion Metodos externos

        #region Funcionalidad personalizada
        private void ArrastrarVentana(object sender, MouseEventArgs args)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Salir(object sender, EventArgs args)
        {
            Application.Exit();
        }

        private void Maximizar(object sender, EventArgs args)
        {
            WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void Restaurar(object sender, EventArgs args)
        {
            WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void Minimizar(object sender, EventArgs args)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ActivarMenu(object sender, EventArgs args)
        {
            if (pnlIzq.Visible)
            {
                pnlIzq.Visible = false;
            }
            else
            {
                menuTransitionMostrar.Show(pnlIzq);
                pnlIzq.Visible = true;
            }
        }

        private void Botones_MouseMove(object sender, MouseEventArgs args)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.Gray;
        }

        private void Botones_MouseLeave(object sender, EventArgs args)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.FromArgb(30, 30, 46);
        }
        #endregion Funcionalidad personalizada
    }
}