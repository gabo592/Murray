using System;
using System.Drawing;

namespace Murray.Poco
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public int ID_Proveedor { get; set; }
        public Image Imagen { get; set; }
        public string Descripcion { get; set; }
        public int IDGrupo { get; set; }
    }
}
