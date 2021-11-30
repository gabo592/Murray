using Models.Interfaces;

namespace Models.Common
{
    /// <summary>
    ///     Modelado de la tabla Categoria
    /// </summary>
    public class Categoria : IIdentity, INameable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        #region Foreing Key

        /// <summary>
        ///     Id del Producto
        /// </summary>
        public int IdProducto { get; set; }

        #endregion
    }
}
