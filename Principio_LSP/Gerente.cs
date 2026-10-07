namespace Principio_LSP
{
    public class Gerente : Funcionario
    {
        public float Bonus { get; set; }

        public Gerente(string Nome, string Carga) : base(Nome, Carga)
        {
        }

        public override double CalcularSalario(double salario)
        {
            return salario + Bonus;
        }
    }
}
