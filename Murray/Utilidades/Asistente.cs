using System;
using System.Net;
using System.Net.Mail;

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
    }
}
