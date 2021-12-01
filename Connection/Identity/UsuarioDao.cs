using Common.Util;
using Connection.Base;
using Connection.Constants;
using Connection.Interfaces.Identity;
using Models.Identity;

using System.Collections.Generic;
using System.Linq;

namespace Connection.Identity
{
    /// <inheritdoc cref="IUsuarioDao"/>
    internal class UsuarioDao : BaseDao<Usuario>, IUsuarioDao
    {
        #region Constructors

        /// <summary>
        ///     Constructor base
        /// </summary>
        public UsuarioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {

        }

        #endregion

        /// <inheritdoc cref="IDao{TModel}.Create(TModel)"/>
        public override Usuario Create(Usuario model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="IDao{TModel}.Delete(int)"/>
        public override Usuario Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="IDao{TModel}.Read()"/>
        public override IEnumerable<Usuario> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IUsuarioDao.Read(string)"/>
        public IEnumerable<Usuario> Read(string username)
        {
            return Read(StoredProcedures.UsuarioGet, new Dictionary<string, object>
            {
                ["username"] = username
            });
        }

        /// <inheritdoc cref="IDao{TModel}.Update(int, TModel)"/>
        public override Usuario Update(int id, Usuario model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="IUsuarioDao.Login(string, string)"/>
        public Usuario Login(string username, string password)
        {
            if (username.Length > 50)
                Handler.Add("USERNAME_LENGTH_EXCEED");

            if (Handler.HasError())
                return new Usuario();

            return Read(StoredProcedures.UsuarioLogin, new Dictionary<string, object>
            {
                ["username"] = username,
                ["password"] = password

            }).FirstOrDefault() ?? new Usuario();
        }  
    }
}
