using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murray.Properties;
using Murray.Poco;
using Murray.Utilidades;

namespace Murray.Presentacion.Productos
{
    public partial class FrmCategorias : Form
    {
        private readonly string Conexion;
        private readonly DataTable DataTable;
        private readonly List<Grupo> Grupos;

        public FrmCategorias()
        {
            InitializeComponent();
            Conexion = Settings.Default.ConnectionStrings;
            DataTable = new DataTable();
            Grupos = new List<Grupo>();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarGrupos();
            CargarTarjetas();
        }

        private void CargarGrupos()
        {
            if (DataTable.Rows.Count != 0)
            {
                DataTable.Clear();
            }

            if (Grupos.Count != 0)
            {
                Grupos.Clear();
            }

            try
            {
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
                        ID = (int)DataTable.Rows[i]["ID del Grupo"],
                        Nombre = DataTable.Rows[i]["Nombre"].ToString(),
                        Estado = DataTable.Rows[i]["Estado"].ToString(),
                        Imagen = Asistente.ObtenerImagen((byte[])DataTable.Rows[i]["Imagen"])
                    };

                    Grupos.Add(grupo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTarjetas()
        {
            if (Grupos.Count == 0)
            {
                return;
            }

            if (pnlPrincipal.Controls.Count != 0)
            {
                pnlPrincipal.Controls.Clear();
            }

            foreach (Grupo g in Grupos)
            {
                GroupCard card = new GroupCard(g);
                pnlPrincipal.Controls.Add(card);
            }
        }
    }
}
