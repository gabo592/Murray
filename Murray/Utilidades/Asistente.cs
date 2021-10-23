using System;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.IO;

namespace Murray.Utilidades
{
    public class Asistente
    {
        public static void EnviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                message.IsBodyHtml = true;
                message.To.Add(destinatario);
                message.From = new MailAddress(emisor);
                message.Body = mensaje;
                message.Subject = asunto;
                smtpClient.Credentials = new NetworkCredential(emisor, password);
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(message);
            }
            catch
            {
                throw new Exception("Correo no válido");
            }
        }

        public static Image ObtenerImagen(byte[] bytesImagen)
        {
            MemoryStream memoryStream = new MemoryStream(bytesImagen);
            Image imagen = Image.FromStream(memoryStream);
            return imagen;
        }
    }
}
