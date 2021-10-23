using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Poco;

namespace Murray.Presentacion.Productos
{
    public partial class GroupCard : UserControl
    {
        private readonly Grupo Grupo;

        public GroupCard(Grupo grupo)
        {
            InitializeComponent();
            Grupo = grupo;
        }

        private void GroupCard_Load(object sender, EventArgs e)
        {
            pbImagen.Image = Grupo.Imagen;
            lblNombre.Text = Grupo.Nombre;
        }
    }
}
