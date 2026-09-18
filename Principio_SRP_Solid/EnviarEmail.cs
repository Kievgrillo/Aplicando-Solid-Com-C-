using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_SRP_Solid
{
    public class EnviarEmail
    {
        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }

        public void Enviar()
        {
            // Lógica para enviar o e-mail
            Console.WriteLine($"Enviando e-mail de {EMailFrom} para {EMailTo} com assunto '{EMailSubject}' e corpo '{EMailBody}'");
        }
    }
}
