using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Properties;

namespace Murray.Presentacion.Productos
{
    public partial class FrmProductos : Form
    {
        private readonly string Conexion;
        private readonly DataTable DataTable;

        public FrmProductos()
        {
            InitializeComponent();
            Conexion = Settings.Default.ConnectionStrings;
            DataTable = new DataTable();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            if (DataTable.Rows.Count > 0)
            {
                DataTable.Clear();
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("seleccionar_productos", connection);
                    dataAdapter.Fill(DataTable);

                    dgvProductos.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarProducto_Click(object sender, EventArgs args)
        {
            FrmAgregarProducto agregarProducto = new FrmAgregarProducto();
            agregarProducto.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataTable.Rows.Count != 0)
                {
                    DataTable.Clear();
                }

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("buscar_productos", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@letra", txtBuscar.Text);
                    dataAdapter.Fill(DataTable);
                    dgvProductos.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
