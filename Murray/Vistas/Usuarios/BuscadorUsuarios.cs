using Common.Util;
using Murray.Services.Identity;
using Murray.Vistas.Base;

namespace Murray.Vistas.Usuarios
{
    public partial class BuscadorUsuarios : Buscador
    {
        private readonly ErrorHandler Handler;
        private readonly UserService Service;

        public BuscadorUsuarios()
        {
            Handler = new ErrorHandler();
            Service = new UserService(Handler);

            InitializeComponent();
            LoadDatagrid(Service.GetUsers(string.Empty));
        }
    }
}
