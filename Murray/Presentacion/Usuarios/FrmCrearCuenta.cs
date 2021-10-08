using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Poco;
using Murray.Properties;
using Murray.Enums;
using Murray.Presentacion.Principal;

namespace Murray.Presentacion
{
    public partial class FrmCrearCuenta : Form
    {
        private readonly List<Departamento> Departamentos;
        private readonly List<Municipio> Municipios;
        public static Image Avatar;
        private readonly string Conexion;
        private Usuario Usuario;

        public FrmCrearCuenta()
        {
            InitializeComponent();
            Departamentos = new List<Departamento>();
            Municipios = new List<Municipio>();
            Conexion = Settings.Default.ConnectionStrings;
        }

        private void PbRegresar_Click(object sender, EventArgs e)
        {
            FrmBienvenida bienvenida = new FrmBienvenida();
            bienvenida.Show();
            Hide();
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();

            cmbCargo.Items.AddRange(Enum.GetValues(typeof(Cargos)).Cast<object>().ToArray());
            cmbCargo.SelectedIndex = 0;
        }

        private void CargarDepartamentos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("seleccionar_departamentos", connection);

                    dataAdapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Departamento departamento = new Departamento
                        {
                            ID = (int)dataTable.Rows[i]["ID"],
                            Nombre = dataTable.Rows[i]["Nombre de Departamento"].ToString()
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
                using (SqlConnection connection = new SqlConnection(Conexion))
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
                            ID = (int)data.Rows[i]["ID"],
                            Nombre = data.Rows[i]["Nombre del Municipio"].ToString(),
                            ID_Departamento = (int)data.Rows[i]["ID del Departamento"]
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

        private void PbAvatar_Click(object sender, EventArgs e)
        {
            FrmAvatares avatares = new FrmAvatares();
            avatares.ShowDialog();

            if (Avatar == null)
            {
                return;
            }

            pbAvatar.Image = Avatar;
        }

        private void PbAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            CrearUsuario();
            InsertarUsuario(Usuario);
        }

        private void CrearUsuario()
        {
            Usuario = new Usuario
            {
                PrimerNombre = txtPNombre.Text,
                SegundoNombre = txtSNombre.Text,
                PrimerApellido = txtPApellido.Text,
                SegundoApellido = txtSApellido.Text,
                Alias = txtNick.Text,
                Pass = txtPass.Text,
                Imagen = Avatar,
                Cargo = cmbCargo.SelectedItem.ToString(),
                Correo = txtCorreo.Text,
                ID_Municipio = ObtenerIDMunicipio(cmbMunicipio.SelectedItem.ToString())
            };
        }

        private void InsertarUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("insertar_usuario", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@primerNombre", usuario.PrimerNombre);
                    command.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre);
                    command.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido);
                    command.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido);
                    command.Parameters.AddWithValue("@alias", usuario.Alias);
                    command.Parameters.AddWithValue("@pass", usuario.Pass);

                    MemoryStream memoryStream = new MemoryStream();
                    usuario.Imagen.Save(memoryStream, usuario.Imagen.RawFormat);
                    command.Parameters.AddWithValue("@avatar", memoryStream.GetBuffer()); 

                    command.Parameters.AddWithValue("@cargo", usuario.Cargo);
                    command.Parameters.AddWithValue("@correo", usuario.Correo);
                    command.Parameters.AddWithValue("@idMunicipio", usuario.ID_Municipio);

                    command.ExecuteNonQuery();
                }

                FrmPrincipal principal = new FrmPrincipal(Usuario);
                principal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIDMunicipio(string nombreMunicipio)
        {
            int idMunicipio = 0;

            foreach (Municipio m in Municipios)
            {
                if (m.Nombre.Equals(nombreMunicipio, StringComparison.CurrentCultureIgnoreCase))
                {
                    idMunicipio = m.ID;
                    break;
                }
            }

            return idMunicipio;
        }

        private bool ValidarCampos()
        {
            if (Avatar == null)
            {
                MessageBox.Show(this, "Seleccione un avatar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPNombre.Text))
            {
                MessageBox.Show(this, "Digite el primer nombre", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPApellido.Text))
            {
                MessageBox.Show(this, "Digite el primer apellido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(this, "Digite un correo electrónico", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                MailAddress mailAddress = new MailAddress(txtCorreo.Text);

                if (mailAddress.Address != txtCorreo.Text)
                {
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtNick.Text))
            {
                MessageBox.Show(this, "Digite un nombre de usuario (NickName)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show(this, "Digite una contraseña", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtPass.Text.Length < 4)
            {
                MessageBox.Show(this, "Digite una contraseña de al menos 5 caracteres", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void PbMostrarPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar.Equals('*'))
            {
                txtPass.PasswordChar = '\0';
                pbMostrarPass.Image = Resources.invisible;
            }
            else
            {
                txtPass.PasswordChar = '*';
                pbMostrarPass.Image = Resources.eye;
            }
        }

        private void FrmCrearCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
