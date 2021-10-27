using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;
using Murray.Modelos;
using Murray.Presentacion;

namespace Murray.Controladores
{
    public class ControladorUsuario
    {
        private readonly UsuarioModel usuarioModel;
        private readonly UbicacionModel ubicacionModel;
        private readonly FrmCrearCuenta frmCrearCuenta;
        private readonly FrmIniciarSesion frmIniciarSesion;

        public ControladorUsuario(FrmCrearCuenta frmCrearCuenta)
        {
            usuarioModel = new UsuarioModel();
            ubicacionModel = new UbicacionModel();
            this.frmCrearCuenta = frmCrearCuenta;
        }

        public ControladorUsuario(FrmIniciarSesion frmIniciarSesion)
        {
            usuarioModel = new UsuarioModel();
            this.frmIniciarSesion = frmIniciarSesion;
        }

        public void CargarDepartamentos()
        {
            ubicacionModel.CargarDepartamentos();

            for (int i = 0; i < ubicacionModel.Departamentos.Count; i++)
            {
                frmCrearCuenta.CmbDepartamento.Items.Add(ubicacionModel.Departamentos.ToArray()[i].Nombre);
            }

            frmCrearCuenta.CmbDepartamento.SelectedIndex = 0;
        }

        public void CargarMunicipios()
        {
            if (frmCrearCuenta.CmbMunicipio.Items.Count != 0)
            {
                frmCrearCuenta.CmbMunicipio.Items.Clear();
            }

            ubicacionModel.CambioDepartamento(frmCrearCuenta.CmbDepartamento.SelectedItem.ToString());

            for (int i = 0; i < ubicacionModel.Municipios.Count; i++)
            {
                frmCrearCuenta.CmbMunicipio.Items.Add(ubicacionModel.Municipios.ToArray()[i].Nombre);
            }

            frmCrearCuenta.CmbMunicipio.SelectedIndex = 0;
        }

        public void CrearCuenta()
        {
            (bool pasa, string mensaje) = ValidarCampos();

            if (!pasa)
            {
                throw new Exception(mensaje);
            }

            string primerNombre = frmCrearCuenta.TxtPNombre.Text;
            string segundoNombre = frmCrearCuenta.TxtSNombre.Text;
            string primerApellido = frmCrearCuenta.TxtPApellido.Text;
            string segundoApellido = frmCrearCuenta.TxtSApellido.Text;
            string alias = frmCrearCuenta.TxtNick.Text;
            string pass = frmCrearCuenta.TxtPass.Text;
            Image avatar = frmCrearCuenta.PbAvatar.Image;
            string cargo = frmCrearCuenta.CmbCargo.SelectedItem.ToString();
            string correo = frmCrearCuenta.TxtCorreo.Text;
            int idMunicipio = ubicacionModel.ObtenerIDMunicipio(frmCrearCuenta.CmbMunicipio.SelectedItem.ToString());

            usuarioModel.InsertarUsuario(usuarioModel.CrearUsuario(primerNombre, segundoNombre, primerApellido, segundoApellido, alias, pass, avatar, cargo, correo, idMunicipio));
        }

        public void SeleccionarUsuarios()
        {
            usuarioModel.SeleccionarUsuarios();

            for (int i = 0; i < usuarioModel.DataTableUsuarios.Rows.Count; i++)
            {
                frmIniciarSesion.PnlPrincipal.Controls.Add(new UserCard(usuarioModel.CargarUsuarios(usuarioModel.DataTableUsuarios, i), frmIniciarSesion));
            }
        }

        public void RegresarAFrameAnterior(Form formuActual, Form formARegresar)
        {
            formARegresar.Show();
            formuActual.Hide();
        }

        private (bool, string) ValidarCampos()
        {
            (bool pase, string mensaje) respuesta;

            if (FrmCrearCuenta.Avatar == null)
            {
                respuesta = (false, "Seleccione un avatar");
                return respuesta;
            }

            if (string.IsNullOrWhiteSpace(frmCrearCuenta.TxtPNombre.Text))
            {
                respuesta = (false, "Digite el primer nombre");
                return respuesta;
            }

            if (string.IsNullOrWhiteSpace(frmCrearCuenta.TxtPApellido.Text))
            {
                respuesta = (false, "Digite el primer apellido");
                return respuesta;
            }

            if (string.IsNullOrWhiteSpace(frmCrearCuenta.TxtCorreo.Text))
            {
                respuesta = (false, "Digite un correo electrónico");
                return respuesta;
            }
            else
            {
                MailAddress mailAddress = new MailAddress(frmCrearCuenta.TxtCorreo.Text);

                if (mailAddress.Address != frmCrearCuenta.TxtCorreo.Text)
                {
                    return (false, "Correo electrónico no válido");
                }
            }

            if (string.IsNullOrWhiteSpace(frmCrearCuenta.TxtNick.Text))
            {
                respuesta = (false, "Digite un nombre de usuario (NickName)");
                return respuesta;
            }

            if (string.IsNullOrWhiteSpace(frmCrearCuenta.TxtPass.Text))
            {
                respuesta = (false, "Digite una contraseña");
                return respuesta;
            }
            else if (frmCrearCuenta.TxtPass.Text.Length < 4)
            {
                respuesta = (false, "Digite una contraseña de al menos 5 caracteres");
                return respuesta;
            }

            return (true, "Todos los campos aceptados");
        }
    }
}
