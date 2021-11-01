using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Murray.Modelos;
using Murray.Poco;
using Murray.Vistas;

namespace Murray.Controladores
{
    public class ControladorUsuario
    {
        private readonly FrmLogin frmLogin;
        private readonly UsuarioModel usuarioModel;

        public ControladorUsuario(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            usuarioModel = new UsuarioModel();
        }

        public void ValidarUsuario()
        {
            string nickName = frmLogin.TxtUsuario.Text;
            string password = frmLogin.TxtContraseña.Text;

            Usuario usuario = usuarioModel.ValidarUsuario(nickName, password);

            if (usuario == null)
            {
                throw new Exception("Favor revisar los datos ingresados");
            }

            frmLogin.Hide();
            FrmPrincipal principal = new FrmPrincipal(usuario);
            principal.Show();
        }
    }
}
