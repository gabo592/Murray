using Models.Interfaces;

namespace Models.Common
{
    /// <summary>
    /// Modelado de la tabla Producto
    /// </summary>
    public class Producto : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }

        #region Foreing Key

        /// <summary>
        ///     Id del Producto
        /// </summary>
        public int IdCategoria { get; set; }

        #endregion
    }
}