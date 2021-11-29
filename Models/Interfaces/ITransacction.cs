using System;

namespace Models.Interfaces
{
    public interface ITransacction
    {
        DateTime Fecha { get; set; }
        decimal Total { get; set; }
        int IdEmpleado { get; set; }
    }
}
