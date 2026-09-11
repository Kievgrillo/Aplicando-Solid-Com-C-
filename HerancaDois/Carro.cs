using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDois
{
    public class Carro : Veiculo
    {
        public Carro(string numeroChassi) : base(numeroChassi)  
        {
            Console.WriteLine("Inicializando Carro com Chassi: " + numeroChassi);
        }
        public Carro()
        {
            Console.WriteLine("Inicializando Carro");
        }
    }
}
