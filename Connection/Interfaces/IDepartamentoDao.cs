using Connection.Base;
using Models.Common;
using System.Collections.Generic;

namespace Connection.Interfaces
{
    /// <summary>
    ///     DAO del modelo de departamento
    /// </summary>
    public interface IDepartamentoDao : IDao<Departamento>
    {
        /// <summary>
        ///     Busca todos los departamento de la base de datos
        /// </summary>
        /// <param name="nombre">
        ///     Nombre a filtrar
        /// </param>
        IEnumerable<Departamento> Read(string nombre);
    }
}
