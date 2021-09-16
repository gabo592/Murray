using System;
using System.Windows.Forms;

namespace Murray.Presentacion
{
    public partial class FrmAvatares : Form
    {
        public FrmAvatares()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs args)
        {
            PictureBox pictureBox = (PictureBox)sender;

            FrmCrearCuenta.Avatar = pictureBox.Image;

            Close();
        }
    }
}
