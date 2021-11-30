namespace Models.Interfaces
{
    /// <summary>
    ///     Detalle de una transacción
    /// </summary>
    public interface ITransacctionDetail
    {
        /// <summary>
        ///     Id del producto del detalle
        /// </summary>
        int IdProducto { get; set; }
        
        /// <summary>
        ///     Cantidad relacionada de la transacción con respecto al producto
        /// </summary>
        int Cantidad { get; set; }

        /// <summary>
        ///     Valor unitario del elemento
        /// </summary>
        decimal Precio { get; set; }

        /// <summary>
        ///     Monto de descuento a aplicar en el conjunto de elementos
        /// </summary>
        decimal Descuento { get; set; }

        /// <summary>
        ///     Subtotal del detalle
        /// </summary>
        decimal Subtotal { get; set; }
    }
}
