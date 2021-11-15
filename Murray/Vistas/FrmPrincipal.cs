using System.Windows.Forms;

namespace Murray.Vistas
{
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(this, "¿Desea cerrar el programa?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            e.Cancel = false;
            Application.Exit();
        }
    }
}
