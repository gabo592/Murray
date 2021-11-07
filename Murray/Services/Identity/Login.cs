using Common.Util;
using Connection.Interfaces;
using Models.Identity;
using System;

namespace Murray.Services.Identity
{
    /// <summary>
    ///     Clase auxiliar para el uso en la vista de
    ///     login
    /// </summary>
    internal class Login : IDisposable
    {
        #region Private Fields

        /// <summary>
        ///     DAO de conexion con el usuario
        /// </summary>
        private readonly IUserDao Dao;

        /// <summary>
        ///     Administrador de erroes
        /// </summary>
        private readonly ErrorHandler Handler;

        #endregion

        #region Constructors
        
        /// <summary>
        ///     Constructor
        /// </summary>
        public Login(ErrorHandler handler)
        {
            Handler = handler;
            Dao = DaoFactory.Get<IUserDao>(handler);
        }

        #endregion

        /// <summary>
        ///     Realiza inicio de sesion
        /// </summary>
        /// <param name="username">
        ///     Nombre del usuario
        /// </param>
        /// <param name="password">
        ///     Contrasena del usuario
        /// </param>
        public User DoLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
                Handler.Add("USERNAME_IS_EMPTY");

            if (string.IsNullOrEmpty(password))
                Handler.Add("PASSWORD_IS_EMPTY");

            if (Handler.HasError())
                return new User();

            return Dao.Login(username, password);
        }

        /// <inheritdoc cref="IDisposable.Dispose"/>
        public void Dispose()
        {
            Dao.Dispose();
            Handler.Clear();
        }
    }
}
