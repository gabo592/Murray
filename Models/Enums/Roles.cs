using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    internal enum Roles
    {
        /*
         * Acceso a las ventas en su totalidad y a los clientes. 
         * Con los productos solo podrá verlos y editarlos (vender).
         */
        Vendedor,

        /*
         * Acceso a las compras en su totalidad y a los proveedores. 
         * Los productos solo podrá verlos y editarlos (comprar).
         */
        GestorDeCompras,

        //Acceso a los productos en su totalidad
        ControlDeInventario,

        //Acceso a los empleados en su totalidad
        RecursosHumanos,

        /*
         * Encargado de la seguridad.
         * Puede visualizar el estado general del emprendimiento (Reportes)
         */
        Supervisor
    }
}
