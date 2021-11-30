using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Util;
using Connection.Base;
using Connection.Constants;
using Connection.Interfaces;
using Models.Identity;

namespace Connection.Identity
{
    internal class ContactoDao : BaseDao<Contacto>, IContactoDao
    {
        #region Constructor
        public ContactoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
        }
        #endregion

        /// <inheritdoc cref="IDao{TModel}.Create(TModel)"/>/>
        public override Contacto Create(Contacto model)
        {
            return Read(StoredProcedures.ContactoCreate, new Dictionary<string, object>
            {
                ["PrimerNombre"] = model.PrimerNombre,
                ["SegundoNombre"] = model.SegundoNombre,
                ["PrimerApellido"] = model.PrimerApellido,
                ["SegundoApellido"] = model.SegundoApellido,
                ["FechaNacimiento"] = model.FechaNacimiento,
                ["Direccion"] = model.Direccion,
                ["RazonSocial"] = model.RazonSocial,
                ["IdMunicipio"] = model.IdMunicipio
            }).FirstOrDefault() ?? new Contacto();
        }

        /// <inheritdoc cref="IDao{TModel}.Delete(int)"/>
        public override Contacto Delete(int id)
        {
            return Read(StoredProcedures.ContactoDelete, new Dictionary<string, object>
            {
                ["Id"] = id
            }).FirstOrDefault() ?? new Contacto();
        }

        /// <inheritdoc cref="IContactoDao.Read(string)"/>
        public IEnumerable<Contacto> Read(string value)
        {
            return Read(StoredProcedures.ContactoRead, new Dictionary<string, object>
            {
                ["Id"] = null,
                ["PrimerNombre"] = value,
                ["SegundoNombre"] = value,
                ["PrimerApellido"] = value,
                ["SegundoApellido"] = value,
                ["FechaNacimiento"] = null,
                ["Direccion"] = value,
                ["RazonSocial"] = value,
                ["IdMunicipio"] = null
            });
        }

        /// <inheritdoc cref="IDao{TModel}.Read"/>
        public override IEnumerable<Contacto> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IDao{TModel}.Update(int, TModel)"/>
        public override Contacto Update(int id, Contacto model)
        {
            return Read(StoredProcedures.ContactoUpdate, new Dictionary<string, object>
            {
                ["Id"] = id,
                ["PrimerNombre"] = model.PrimerNombre,
                ["SegundoNombre"] = model.SegundoNombre,
                ["PrimerApellido"] = model.PrimerApellido,
                ["SegundoApellido"] = model.SegundoApellido,
                ["FechaNacimiento"] = model.FechaNacimiento,
                ["Direccion"] = model.Direccion,
                ["RazonSocial"] = model.RazonSocial,
                ["IdMunicipio"] = model.IdMunicipio
            }).FirstOrDefault() ?? new Contacto();
        }
    }
}
