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
using Murray.Poco;
using Murray.Properties;

namespace Murray.Presentacion.Proveedores
{
    public partial class FrmProveedores : Form
    {
        private readonly string Conexion;
        private DataTable DataTable;

        public FrmProveedores()
        {
            InitializeComponent();
            Conexion = Settings.Default.ConnectionStrings;
            DataTable = new DataTable();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                if (DataTable.Rows.Count > 0)
                {
                    DataTable.Clear();
                }

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("mostrar_proveedores", connection);
                    dataAdapter.Fill(DataTable);
                    dgvProveedores.DataSource = DataTable;
                    dgvProveedores.Columns["Estado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PbAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProveedor agregarProveedor = new FrmAgregarProveedor();
            agregarProveedor.ShowDialog();
            CargarDatos();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void Buscar(string text)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("buscar_proveedor", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@letra", text);

                    if (DataTable.Rows.Count > 0)
                    {
                        DataTable.Clear();
                    }

                    dataAdapter.Fill(DataTable);
                    dgvProveedores.DataSource = DataTable;
                    dgvProveedores.Columns["Estado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
