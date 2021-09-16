using System;
using System.Windows.Forms;

namespace Murray
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmBienvenida bienvenida = new FrmBienvenida();
            bienvenida.Show();
            Application.Run();
        }
    }
}
