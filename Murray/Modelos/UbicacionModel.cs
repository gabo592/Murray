using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Murray.Poco;
using Murray.Properties;

namespace Murray.Modelos
{
    public class UbicacionModel
    {
        public List<Municipio> Municipios { get; }
        public List<Departamento> Departamentos { get; }
        private readonly string Conexion;

        public UbicacionModel()
        {
            Municipios = new List<Municipio>();
            Departamentos = new List<Departamento>();
            Conexion = Settings.Default.ConnectionStrings;
        }

        public int ObtenerIDMunicipio(string nombreMunicipio)
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

        public void CargarDepartamentos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Conexion))
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter("vista_departamentos", connection);

                dataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Departamento departamento = new Departamento
                    {
                        ID = (int)dataTable.Rows[i]["ID"],
                        Nombre = dataTable.Rows[i]["Nombre de Departamento"].ToString()
                    };

                    Departamentos.Add(departamento);
                }
            }
        }

        public void CambioDepartamento(string nombreDepartamentoSeleccionado)
        {
            if (Municipios.Count != 0)
            {
                Municipios.Clear();
            }

            int idDepartamento = 0;
            DataTable data = new DataTable();

            foreach (Departamento d in Departamentos)
            {
                if (d.Nombre.Equals(nombreDepartamentoSeleccionado, StringComparison.CurrentCultureIgnoreCase))
                {
                    idDepartamento = d.ID;
                    break;
                }
            }

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
                }
            }
        }
    }
}
