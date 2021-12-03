using System.Windows.Forms;

namespace Murray.Vistas.Compras
{
    public partial class EditorCompras : Form
    {
        public EditorCompras()
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
