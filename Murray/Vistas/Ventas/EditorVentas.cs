using System.Windows.Forms;

namespace Murray.Vistas.Ventas
{
    public partial class EditorVentas : Form
    {
        public EditorVentas()
        {
            InitializeComponent();
        }

        #region Public Methods

        public void LoadRecord(int id)
        {
            var isNew = id.Equals(default);
        }

        #endregion

        #region Private Methods

        private void ApplyChanges()
        {
        }

        #endregion
    }
}
