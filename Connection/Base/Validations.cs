using Common.Util;
using Models.Interfaces;

namespace Connection.Base
{
    /// <summary>
    ///     Validaciones de datos relacionado a modelos
    /// </summary>
    internal static class Validations
    {
        /// <summary>
        ///     Realiza validaciones genericas con base a el tipo de modelo correspondiente
        /// </summary>
        /// <typeparam name="TModel">
        ///     Modelo a validar
        /// </typeparam>
        /// <param name="model">
        ///     Registro del modelo
        /// </param>
        /// <param name="handler">
        ///     Administrador de errores
        /// </param>=
        public static bool Validate<TModel>(TModel model, ErrorHandler handler) where TModel : new()
        {
            if (model == null)
            {
                handler.Add("MODEL_IS_NULL");
                return false;
            }

            if (model is INameable nameable)
            {
                if (string.IsNullOrEmpty(nameable.Nombre))
                    handler.Add("NOMBRE_IS_EMPTY");
            }
            
            return handler.HasError();
        }
    }
}
