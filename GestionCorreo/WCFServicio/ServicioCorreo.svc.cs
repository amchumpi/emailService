using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Upc.Springfield.GestionCorrreo.Entidades;

namespace Upc.Springfield.GestionCorrreo.WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCorreo" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioCorreo.svc o ServicioCorreo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioCorreo : IServicioCorreo
    {
        public void EnviarCorreo(Email correo)
        {
            Negocio.ReglasCorreo reglasCorreo = null;
            try
            {
                reglasCorreo = new Negocio.ReglasCorreo();
                reglasCorreo.EnviarCorreo(correo);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo enviar correo[ServicioCorreo].\nError:" + ex.Message,ex);
            }
            finally
            {
                if (reglasCorreo != null)
                {
                    reglasCorreo.Dispose();
                    reglasCorreo = null;
                }                
            }
        }
    }
}
