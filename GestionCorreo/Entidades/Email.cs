using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Upc.Springfield.GestionCorrreo.Entidades
{
    [DataContract(Name ="Email")]
    public class Email
    {
        [DataMember(Name = "De")]
        public string De { get; set; }
        [DataMember(Name = "Para")]
        public List<string> Para { get; set; }
        [DataMember(Name = "Cc")]
        public List<string> Cc { get; set; }
        [DataMember(Name = "Bcc")]
        public List<string> Bcc { get; set; }
        [DataMember(Name = "Asunto")]
        public string Asunto { get; set; }
        [DataMember(Name = "Mensaje")]
        public string Mensaje { get; set; }
        [DataMember(Name = "ConFormatoHtml")]
        public bool ConFormatoHtml { get; set; }

        public Email()
        {
            De = "";
            Para = new List<string>();
            Cc = new List<string>();
            Bcc = new List<string>();
            Asunto = "";
            Mensaje = "";
            ConFormatoHtml = false;
        }
    }
}
