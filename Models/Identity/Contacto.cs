using System;

namespace Models.Identity
{
    public class Contacto
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string RazonSocial { get; set; }
        public int IdMunicipio { get; set; }
    }
}
