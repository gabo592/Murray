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

namespace Murray.Presentacion
{
    public partial class FrmRecuperarContrasena : Form
    {
        private readonly string Conexion;
        private DataTable DataTable;

        public FrmRecuperarContrasena()
        {
            InitializeComponent();
            Conexion = Settings.Default.ConnectionStrings;
            DataTable = new DataTable();
        }

        private void FrmRecuperarContrasena_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("mostrar_usuario_y_correo", connection);

                    if (DataTable.Rows.Count > 0)
                    {
                        DataTable.Clear();
                    }

                    dataAdapter.Fill(DataTable);
                    dgvUsuarios.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("buscar_usuario_y_correo", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@letra", txtBuscar.Text);

                    if (DataTable.Rows.Count > 0)
                    {
                        DataTable.Clear();
                    }

                    dataAdapter.Fill(DataTable);
                    dgvUsuarios.DataSource = DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
