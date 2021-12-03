using Common.Util;
using Murray.Services.Transacctions;
using Murray.Vistas.Base;

namespace Murray.Vistas.Ventas
{
    public partial class BuscadorVentas : Buscador
    {
        private readonly ErrorHandler Handler;
        private readonly TransactionService Service;

        public BuscadorVentas()
        {
            Handler = new ErrorHandler();
            Service = new TransactionService(Handler);

            InitializeComponent();
            LoadDatagrid(Service.GetVentas(string.Empty));
        }
    }
}
