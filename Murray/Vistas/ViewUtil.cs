using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murray.Vistas
{
    internal static class ViewUtil
    {
        /// <summary>
        ///     Inicializa columnas de tabla de datos
        /// </summary>
        /// <param name="model">
        ///     Modelo a utilizar para inicializar tabla
        /// </param>
        public static void InitDatagrid(BunifuDataGridView datagrid, Type model)
        {
            if (datagrid is null || model is null)
                return;

            if (datagrid.ColumnCount > 0)
                datagrid.Columns.Clear();

            foreach (var property in model.GetProperties())
            {
                datagrid.Columns.Add(property.Name, property.Name);
            }
        }
    }
}
