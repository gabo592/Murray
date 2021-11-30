﻿using System.Collections.Generic;
using Connection.Base;
using Models.Identity;

namespace Connection.Interfaces
{
    /// <summary>
    ///     Conexion a la base de datos con el objeto Contacto
    /// </summary>
    public interface IContactoDao : IDao<Contacto>
    {
        /// <summary>
        ///     Busca todos los contactos en la base de datos
        /// </summary>
        /// <param name="value">
        ///     Busca contactos con el valor como filtro
        /// </param>
        /// <returns>
        ///     Lista de contactos con coincidencia en el filtro
        /// </returns>
        IEnumerable<Contacto> Read(string value);
    }
}
