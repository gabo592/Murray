using Common.Util;
using Murray.Services.Common;
using Murray.Vistas.Base;

namespace Murray.Vistas.Productos
{
    public partial class BuscadorProductos : Buscador
    {
        private readonly ErrorHandler Handler;
        private readonly StockService Service;

        public BuscadorProductos()
        {
            Handler = new ErrorHandler();
            Service = new StockService(Handler);

            InitializeComponent();
            LoadDatagrid(Service.GetProductos(string.Empty));
        }
    }
}
