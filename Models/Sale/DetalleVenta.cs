using Models.Interfaces;

namespace Models.Sale
{
    /// <summary>
    ///     Elemnto a vender
    /// </summary>
    public class DetalleVenta : IIdentity, ITransacctionDetail
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="ITransacctionDetail.Cantidad"/>
        public int Cantidad { get; set; }

        /// <inheritdoc cref="ITransacctionDetail.Precio"/>
        public decimal Precio { get; set; }

        /// <inheritdoc cref="ITransacctionDetail.Descuento"/>
        public decimal Descuento { get; set; }

        /// <inheritdoc cref="ITransacctionDetail.Subtotal"/>
        public decimal Subtotal { get; set; }

        #region Foreing Keys

        /// <inheritdoc cref="ITransacctionDetail.IdProducto"/>
        public int IdProducto { get; set; }

        /// <summary>
        ///     Id de la venta asociado detalle
        /// </summary>
        public int IdVenta { get; set; }

        #endregion
    }
}
