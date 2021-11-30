namespace Connection.Constants
{
    /// <summary>
    ///     Constantes de los nombres de los procedimientos de almanezado que existen
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region Identity

        public const string UserLogin = "USER_LOGIN";
        public const string GetUsers = "GET_USERS";

        #endregion

        #region Contacto

        public const string ContactoCreate = "CONTACTO_CREATE";
        public const string ContactoRead = "CONTACTO_GET";
        public const string ContactoUpdate = "CONTACTO_UPDATE";
        public const string ContactoDelete = "CONTACTO_DELETE";

        #endregion

        #region Empleado

        public const string EmpleadoCreate = "EMPLEADO_CREATE";
        public const string EmpleadoRead = "EMPLEADO_GET";
        public const string EmpleadoUpdate = "EMPLEADO_UPDATE";
        public const string EmpledaoDelete = "EMPLEADO_DELETE";

        #endregion
    }
}
