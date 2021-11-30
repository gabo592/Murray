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

        #region Common

        public const string DepartamentoCreate = "DEPARTAMENTO_CREATE";
        public const string DepartamentoGet = "DEPARTAMENTO_GET";
        public const string DepartamentoUpdate = "DEPARTAMENTO_UPDATE";
        public const string DepartamentoDelete = "DEPARTAMENTO_DELETE";

        public const string ContactoCreate = "CONTACTO_CREATE";
        public const string ContactoGet = "CONTACTO_GET";
        public const string ContactoUpdate = "CONTACTO_UPDATE";
        public const string ContactoDelete = "CONTACTO_DELETE";

        public const string EmpleadoCreate = "EMPLEADO_CREATE";
        public const string EmpleadoGet = "EMPLEADO_GET";
        public const string EmpleadoUpdate = "EMPLEADO_UPDATE";
        public const string EmpledaoDelete = "EMPLEADO_DELETE";

        #endregion
    }
}
