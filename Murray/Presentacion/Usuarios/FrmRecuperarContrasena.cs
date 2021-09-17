using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Murray.Properties;
using Murray.Utilidades;

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
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("seleccionar_usuarios", connection);

                    dataAdapter.Fill(DataTable);
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = DataTable;
            dgvUsuarios.Columns["ID_Usuario"].Visible = false;
            dgvUsuarios.Columns["Primer_Nombre"].Visible = false;
            dgvUsuarios.Columns["Segundo_Nombre"].Visible = false;
            dgvUsuarios.Columns["Primer_Apellido"].Visible = false;
            dgvUsuarios.Columns["Segundo_Apellido"].Visible = false;
            dgvUsuarios.Columns["Pass"].Visible = false;
            dgvUsuarios.Columns["Avatar"].Visible = false;
            dgvUsuarios.Columns["Cargo"].Visible = false;
            dgvUsuarios.Columns["Estado"].Visible = false;
            dgvUsuarios.Columns["ID_Municipio"].Visible = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("buscar_usuario_por_correo_y_nick", connection);
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

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                string correoUsuario;
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("recuperar_pass_usuario", connection);
                    string nickname = dgvUsuarios.Rows[e.RowIndex].Cells["NickName"].Value.ToString();
                    correoUsuario = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@nickName", nickname);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@correo", correoUsuario);
                    dataAdapter.Fill(data);
                }

                string pass = data.Rows[0]["Pass"].ToString();
                string primerNombre = data.Rows[0]["Primer_Nombre"].ToString();
                string primerApellido = data.Rows[0]["Primer_Apellido"].ToString();
                txtHtml.Text = txtHtml.Text.Replace("@pass", pass);
                txtHtml.Text = txtHtml.Text.Replace("@primerNombre", primerNombre);
                txtHtml.Text = txtHtml.Text.Replace("@primerApellido", primerApellido);

                Asistente.EnviarCorreo(Settings.Default.Correo, Settings.Default.PassCorreo, txtHtml.Text, "Solicitud de Contraseña", correoUsuario);

                MessageBox.Show(this, "Coreo enviado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
