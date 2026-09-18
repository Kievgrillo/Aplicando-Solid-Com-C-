using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_SRP_Solid
{
    public class RegistraLog : ILogger
    {
        public void info(string info)
        {
            // Lógica para registrar o log
            Console.WriteLine($"Registrando log: {info}");
        }
    }    
}

