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
using Murray.Poco;

namespace Murray.Presentacion.Productos
{
    public partial class FrmAgregarProducto : Form
    {
        private DataTable DataTable;
        private readonly string Conexion;
        private List<Proveedor> Proveedores;
        private List<Grupo> Grupos;

        public FrmAgregarProducto()
        {
            InitializeComponent();
            DataTable = new DataTable();
            Conexion = Settings.Default.ConnectionStrings;
            Proveedores = new List<Proveedor>();
            Grupos = new List<Grupo>();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            dtPicker.Value = DateTime.Today;
            CargarProveedores();
            CargarGrupos();
        }

        private void CargarProveedores()
        {
            try
            {
                LimpiarDataTable();

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("mostrar_proveedores", connection);
                    dataAdapter.Fill(DataTable);
                }

                if (DataTable.Rows.Count == 0)
                {
                    return;
                }

                for (int i = 0; i < DataTable.Rows.Count; i++)
                {
                    Proveedor proveedor = new Proveedor
                    {
                        ID = (int)DataTable.Rows[i]["ID"],
                        Nombre = DataTable.Rows[i]["Nombre del Proveedor"].ToString(),
                        Telefono = DataTable.Rows[i]["Telefono"].ToString(),
                        Direccion = DataTable.Rows[i]["Direccion"].ToString(),
                        Estado = DataTable.Rows[i]["Estado"].ToString()
                    };

                    Proveedores.Add(proveedor);
                    cmbProveedores.Items.Add(proveedor.Nombre);
                }

                cmbProveedores.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrupos()
        {
            try
            {
                LimpiarDataTable();

                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("seleccionar_grupos", connection);
                    dataAdapter.Fill(DataTable);
                }

                if (DataTable.Rows.Count == 0)
                {
                    return;
                }

                for (int i = 0; i < DataTable.Rows.Count; i++)
                {
                    Grupo grupo = new Grupo
                    {
                        ID = (int)DataTable.Rows[i]["ID"],
                        Nombre = DataTable.Rows[i]["Nombre del Grupo"].ToString(),
                        Estado = DataTable.Rows[i]["Estado"].ToString()
                    };

                    Grupos.Add(grupo);
                    cmbGrupo.Items.Add(grupo.Nombre);
                }

                cmbGrupo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDataTable()
        {
            if (DataTable.Rows.Count != 0)
            {
                DataTable.Clear();
            }
        }
    }
}
