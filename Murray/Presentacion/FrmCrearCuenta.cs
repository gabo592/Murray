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

namespace Murray.Presentacion
{
    public partial class FrmCrearCuenta : Form
    {
        private List<Departamento> Departamentos;
        private List<Municipio> Municipios;

        public FrmCrearCuenta()
        {
            InitializeComponent();
            Departamentos = new List<Departamento>();
            Municipios = new List<Municipio>();
        }

        private void FrmCrearCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PbRegresar_Click(object sender, EventArgs e)
        {
            FrmBienvenida bienvenida = new FrmBienvenida();
            bienvenida.Show();
            Hide();
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            string conexion = Settings.Default.ConnectionStrings;

            CargarDepartamentos(conexion, dataTable);
        }

        private void CargarDepartamentos(string conexion, DataTable dataTable)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("obtener_departamentos", connection);

                    dataAdapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Departamento departamento = new Departamento
                        {
                            ID = (int)dataTable.Rows[i]["ID_Departamento"],
                            Nombre = dataTable.Rows[i]["Nombre_Departamento"].ToString()
                        };

                        Departamentos.Add(departamento);
                        cmbDepartamento.Items.Add(departamento.Nombre);
                    }

                    cmbDepartamento.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Municipios.Count != 0)
            {
                Municipios.Clear();
            }

            if (cmbMunicipio.Items.Count != 0)
            {
                cmbMunicipio.Items.Clear();
            }

            string nombreDepartamento = cmbDepartamento.SelectedItem.ToString();
            int idDepartamento = 0;
            DataTable data = new DataTable();

            foreach (Departamento d in Departamentos)
            {
                if (d.Nombre.Equals(nombreDepartamento, StringComparison.CurrentCultureIgnoreCase))
                {
                    idDepartamento = d.ID;
                    break;
                }
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectionStrings))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("buscar_municipios", connection);
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@idDepartamento", idDepartamento);

                    dataAdapter.Fill(data);

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        Municipio municipio = new Municipio
                        {
                            ID = (int)data.Rows[i]["ID_Municipio"],
                            Nombre = data.Rows[i]["Nombre_Municipio"].ToString(),
                            ID_Departamento = (int)data.Rows[i]["ID_Departamento"]
                        };

                        Municipios.Add(municipio);

                        cmbMunicipio.Items.Add(municipio.Nombre);
                    }
                }

                cmbMunicipio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
