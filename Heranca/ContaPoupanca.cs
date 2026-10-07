using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class ContaPoupanca : Conta
    {
        public double JurosMensais { get; set; }

        static void Main(string[] args)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Numero = 12345;
            contaPoupanca.Saldo = 1000.0;
            contaPoupanca.GetSaldo();
        } 
    }
}
