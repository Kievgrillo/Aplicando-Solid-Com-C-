namespace Heranca
{
    internal class ContaPoupanca : Conta
    {
        public int JurosMensais { get; set; }    

        protected override void GetSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo}, Juros Mensais: {JurosMensais}");
        }

        static void Main(string[] args)
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Numero = 123;
            contaPoupanca.Saldo = 1000.00;
            contaPoupanca.GetSaldo();
        }
    }
}
