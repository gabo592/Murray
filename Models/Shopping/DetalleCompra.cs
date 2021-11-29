using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Shopping
{
    public class DetalleCompra : IIdentity, ITransacctionDetail
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
    }
}
