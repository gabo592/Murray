using Connection.Base;
using Models.Sale;

namespace Connection.Interfaces.Sale
{
    /// <summary>
    ///     Conexion a la base de datos con el objeto DetalleVenta
    /// </summary>
    public interface IDetalleVentaDao : IDao<DetalleVenta>
    {
    }
}
