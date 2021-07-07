using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Upc.Springfield.GestionCorrreo.Negocio.Utiles
{
    public class GestionCorreo
    {
        public void SendEmail(Entidades.Email correo)
        {
            MailMessage mmsg = null;
            SmtpClient cliente = null;
            try
            {
                mmsg = MapearDatosCorreo(correo);
                cliente = InstanciarClienteGmail();

                cliente.Send(mmsg);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo enviar correo[SendEmail].\nError: " + ex.Message,ex);
            }
            finally
            {
                mmsg = null;
                cliente = null;
            }

        }

        private MailMessage MapearDatosCorreo(Entidades.Email correo)
        {
            MailMessage mmsg = new MailMessage();
            foreach (string correoPara in correo.Para)
            {
                if (correoPara.Trim() != "") mmsg.To.Add(correoPara);
            }
            foreach (string correoCc in correo.Cc)
            {
                if (correoCc.Trim() != "") mmsg.CC.Add(correoCc);
            }
            foreach (string correoBcc in correo.Bcc)
            {
                if (correoBcc.Trim() != "") mmsg.Bcc.Add(correoBcc);
            }

            mmsg.Subject = correo.Asunto;
            mmsg.SubjectEncoding = Encoding.UTF8;
            mmsg.Body = correo.Mensaje;
            mmsg.BodyEncoding = Encoding.UTF8;
            mmsg.IsBodyHtml = correo.ConFormatoHtml;
            mmsg.From = new MailAddress(correo.De);

            return mmsg;
        }

        private SmtpClient InstanciarClienteGmail()
        {
            SmtpClient smtpCliente = null;
            try
            {
                smtpCliente = new SmtpClient();
                smtpCliente.Credentials = new System.Net.NetworkCredential("springfieldtop1@gmail.com","springfield123456");
                smtpCliente.Port = 587;
                smtpCliente.EnableSsl = true;
                smtpCliente.Host = "smtp.gmail.com";

                return smtpCliente;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
