using Models.Interfaces;

namespace Models.Sale
{
    public class DetalleVenta : IIdentity, ITransacctionDetail
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
    }
}
