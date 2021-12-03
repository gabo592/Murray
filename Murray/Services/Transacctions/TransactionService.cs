using Common.Util;
using Connection.Interfaces.Common;
using Connection.Interfaces.Sale;
using Connection.Interfaces.Shopping;

using Murray.Services.Base;
using Murray.ViewModels.Sales;
using Murray.ViewModels.Shopping;

using System.Collections.Generic;
using System.Linq;

namespace Murray.Services.Transacctions
{
    internal class TransactionService : ServiceBase
    {
        private readonly IVentaDao VentaDao;
        private readonly IDetalleVentaDao DetalleVentaDao;
        private readonly ICompraDao CompraDao;
        private readonly IDetalleCompraDao DetalleCompraDao;
        private readonly IEmpleadoDao EmpleadoDao;
        private readonly IProveedorDao ProveedorDao;
        private readonly IClienteDao ClienteDao;
        private readonly IContactoDao ContactoDao;

        public TransactionService(ErrorHandler handler) : base(handler)
        {
            VentaDao = DaoFactory.Get<IVentaDao>(handler);
            DetalleVentaDao = DaoFactory.Get<IDetalleVentaDao>(handler);
            CompraDao = DaoFactory.Get<ICompraDao>(handler);
            DetalleCompraDao = DaoFactory.Get<IDetalleCompraDao>(handler);
            ContactoDao = DaoFactory.Get<IContactoDao>(handler);
            EmpleadoDao = DaoFactory.Get<IEmpleadoDao>(handler);
            ProveedorDao = DaoFactory.Get<IProveedorDao>(handler);
            ClienteDao = DaoFactory.Get<IClienteDao>(handler);
        }

        public IEnumerable<VentaView> GetVentas(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                query = null;

            return VentaDao.Read(query).Select(venta =>
            {
                var detalles = DetalleVentaDao.GetByVentaId(venta.Id).ToList();
                var subtotal = detalles.Sum(x => x.Subtotal);

                var cliente = ClienteDao.GetById(venta.IdCliente);
                var empleado = EmpleadoDao.GetById(venta.IdEmpleado);

                var ccliente = ContactoDao.GetById(cliente.IdContacto);
                var cempleado = ContactoDao.GetById(empleado.IdContacto);

                return new VentaView
                {
                    Id = venta.Id,
                    Fecha = venta.Fecha.ToShortDateString(),
                    Productos = detalles.Count,
                    Cantidad = detalles.Sum(x => x.Cantidad),
                    Subtotal = subtotal,
                    Total = subtotal * 1.15m,
                    Cliente = ccliente.NombreCompleto,
                    Empleado = cempleado.NombreCompleto
                };
            });
        }

        public IEnumerable<CompraView> GetCompras(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                query = null;

            return CompraDao.Read(query).Select(compra =>
            {
                var detalles = DetalleCompraDao.GetByVentaId(compra.Id).ToList();
                var subtotal = detalles.Sum(x => x.Subtotal);

                var proveedor = ClienteDao.GetById(compra.IdProveedor);
                var empleado = EmpleadoDao.GetById(compra.IdEmpleado);

                var cproveedor = ContactoDao.GetById(proveedor.IdContacto);
                var cempleado = ContactoDao.GetById(empleado.IdContacto);

                return new CompraView
                {
                    Id = compra.Id,
                    Fecha = compra.Fecha.ToShortDateString(),
                    Productos = detalles.Count,
                    Cantidad = detalles.Sum(x => x.Cantidad),
                    Subtotal = subtotal,
                    Total = subtotal * 1.15m,
                    Proveedor = cproveedor.NombreCompleto,
                    Empleado = cempleado.NombreCompleto
                };
            });
        }

        public override void Dispose()
        {
            VentaDao.Dispose();
            DetalleVentaDao.Dispose();
            CompraDao.Dispose();
            DetalleCompraDao.Dispose();
            ContactoDao.Dispose();
            EmpleadoDao.Dispose();
            ClienteDao.Dispose();
            ProveedorDao.Dispose();

            Handler.Clear();
        }
    }
}
