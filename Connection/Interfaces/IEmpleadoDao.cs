using System.Collections.Generic;
using Connection.Base;
using Models.Common;

namespace Connection.Interfaces
{
    /// <summary>
    ///     Conexion a la base de datos con el objeto Empleado
    /// </summary>
    public interface IEmpleadoDao : IDao<Empleado>
    {
        /// <summary>
        ///     Busca todos los empleados en la base de datos
        /// </summary>
        /// <param name="estado">
        ///     Filtro para buscar empleados por su estado
        /// </param>
        /// <param name="idContacto">
        ///     Filtro para buscar empleados por el ID de su contacto
        /// </param>
        /// <returns>
        ///     Lista de empleados que coincidan con el filtro
        /// </returns>
        IEnumerable<Empleado> Read(bool estado, int idContacto);
    }
}
