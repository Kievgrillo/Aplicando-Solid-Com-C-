namespace Heranca
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
    
        public Conta()
        {
        }
        
        protected virtual void GetSaldo()
        {
            Console.WriteLine("Saldo 99,99");
        }
    }
}
