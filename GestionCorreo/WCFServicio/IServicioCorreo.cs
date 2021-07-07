using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Upc.Springfield.GestionCorrreo.Entidades;

namespace Upc.Springfield.GestionCorrreo.WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCorreo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCorreo
    {
        [OperationContract]
        [WebInvoke(Method ="POST",UriTemplate ="/EnviarCorreo",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat =WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Wrapped)]
        void EnviarCorreo(Email correo);
    }
}
