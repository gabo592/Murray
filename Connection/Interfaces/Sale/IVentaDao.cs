using Connection.Base;
using Models.Sale;

namespace Connection.Interfaces.Sale
{
    /// <summary>
    ///     Conexion a la base de datos con el objeto Venta
    /// </summary>
    public interface IVentaDao : IDao<Venta>
    {
    }
}
