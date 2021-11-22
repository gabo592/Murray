namespace Models.Interfaces
{
    public interface ITransacctionDetail
    {
        int IdProducto { get; set; }
        int Cantidad { get; set; }
        decimal Precio { get; set; }
        decimal Descuento { get; set; }
        decimal Subtotal { get; set; }
    }
}
