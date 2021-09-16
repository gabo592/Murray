using System.Drawing;

namespace Murray.Poco
{
    public class Usuario
    {
        public int ID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NickName { get; set; }
        public string Pass { get; set; }
        public Image Imagen { get; set; }
        public string Estado { get; set; }
        public int ID_Municipio { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
    }
}
