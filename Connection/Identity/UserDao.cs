using Common.Util;
using Connection.Base;
using Connection.Constants;
using Connection.Interfaces;
using Models.Identity;

using System.Collections.Generic;
using System.Linq;

namespace Connection.Identity
{
    /// <inheritdoc cref="IUserDao"/>
    internal class UserDao : BaseDao<User>, IUserDao
    {
        #region Constructors

        /// <summary>
        ///     Constructor base
        /// </summary>
        public UserDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {

        }

        #endregion

        /// <inheritdoc cref="IDao{TModel}.Create(TModel)"/>
        public override User Create(User model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="IDao{TModel}.Delete(int)"/>
        public override User Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="IDao{TModel}.Read()"/>
        public override IEnumerable<User> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IUserDao.Read(string)"/>
        public IEnumerable<User> Read(string username)
        {
            return Read(StoredProcedures.GetUsers, new Dictionary<string, object>
            {
                ["username"] = username
            });
        }

        /// <inheritdoc cref="IDao{TModel}.Update(int, TModel)"/>
        public override User Update(int id, User model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="IUserDao.Login(string, string)"/>
        public User Login(string username, string password)
        {
            if (username.Length > 50)
                Handler.Add("USERNAME_LENGTH_EXCEED");

            if (Handler.HasError())
                return new User();

            return Read(StoredProcedures.UserLogin, new Dictionary<string, object>
            {
                ["username"] = username,
                ["password"] = password

            }).FirstOrDefault() ?? new User();
        }  
    }
}
