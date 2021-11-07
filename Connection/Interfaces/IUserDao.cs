using Connection.Base;
using Models.Identity;
using System.Collections.Generic;

namespace Connection.Interfaces
{
    /// <summary>
    ///     Conexion a base de datos relacionado con el objeto de usuarios
    ///     del sistema
    /// </summary>
    public interface IUserDao : IDao<User>
    {
        /// <summary>
        ///     Realiza la validacion del login de usuario
        /// </summary>
        /// <param name="username">
        ///     Nombre del usuario
        /// </param>
        /// <param name="password">
        ///     Constrasena del usuario
        /// </param>
        User Login(string username, string password);

        /// <summary>
        ///     Busca todos los usuarios de la base de datos
        /// </summary>
        /// <param name="username">
        ///     Nombre de usuario de filtro
        /// </param>
        IEnumerable<User> Read(string username);
    }
}
