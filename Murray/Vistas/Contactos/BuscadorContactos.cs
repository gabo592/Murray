using Common.Util;
using Murray.Services.Common;
using Murray.Vistas.Base;

namespace Murray.Vistas.Contactos
{
    public partial class BuscadorContactos : Buscador
    {
        private readonly ErrorHandler Handler;
        private readonly ContactosService Service;

        public BuscadorContactos()
        {
            Handler = new ErrorHandler();
            Service = new ContactosService(Handler);

            InitializeComponent();
            LoadDatagrid(Service.GetContactos(string.Empty));
        }
    }
}
