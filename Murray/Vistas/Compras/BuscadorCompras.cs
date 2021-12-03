using Common.Util;
using Murray.Services.Transacctions;
using Murray.Vistas.Base;

namespace Murray.Vistas.Compras
{
    public partial class BuscadorCompras : Buscador
    {
        private readonly ErrorHandler Handler;
        private readonly TransactionService Service;

        public BuscadorCompras()
        {
            Handler = new ErrorHandler();
            Service = new TransactionService(Handler);

            InitializeComponent();
            LoadDatagrid(Service.GetCompras(string.Empty));
        }
    }
}
