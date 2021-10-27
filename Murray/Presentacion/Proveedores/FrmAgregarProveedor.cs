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
using Murray.Observable;

namespace Murray.Presentacion.Proveedores
{
    public partial class FrmAgregarProveedor : Form, ISujeto
    {
        private readonly List<IObservador> Observadors;

        public FrmAgregarProveedor()
        {
            InitializeComponent();
            Observadors = new List<IObservador>();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void PbAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Insertar();
            Limpiar();
        }

        private void Insertar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectionStrings))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insertar_proveedor", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    command.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                    command.ExecuteNonQuery();
                }

                Notificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(this, "Digite un nombre para el proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTelefono.Text.Length != 8)
            {
                MessageBox.Show(this, "El número de teléfono debe tener 8 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show(this, "Digite una dirección para el proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        public void Notificar()
        {
            Observadors.ForEach(o => o.ActualizarEstado());
        }

        public void AgregarObservador(IObservador observador)
        {
            Observadors.Add(observador);
        }
    }
}
