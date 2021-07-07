using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upc.Springfield.GestionCorrreo.Negocio
{
    public class ReglasCorreo:IDisposable
    {

        public void EnviarCorreo(Upc.Springfield.GestionCorrreo.Entidades.Email correo)
        {
            Utiles.GestionCorreo gestionCorreo = null;
            try
            {
                gestionCorreo = new Utiles.GestionCorreo();
                gestionCorreo.SendEmail(correo);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo enviar Correo[ReglasCorreo].\nError:" + ex.Message,ex);
            }
        }

        public void Dispose()
        {
            return;
        }
    }
}
