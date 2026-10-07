namespace Principio_LSP
{
    public class Vendedor : Funcionario
    {
        public float Comissao { get; set; }

        public Vendedor(string Nome, string Carga) : base(Nome, Carga)
        {
        }

        public override double CalcularSalario(double salario)
        {
            return salario + Comissao;
        }
    }
}
