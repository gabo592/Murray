namespace Murray.ViewModels.Shopping
{
    internal class CompraView
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Proveedor { get; set; }
        public string Empleado { get; set; }
        public int Productos { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}
