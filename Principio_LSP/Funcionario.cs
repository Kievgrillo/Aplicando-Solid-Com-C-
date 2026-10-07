namespace Principio_LSP
{
    public class Funcionario
    {
        private string? Nome { get; set; }
        private string? Carga { get; set; }

        public  Funcionario(string Nome, string Carga)
        {
            Nome = Nome;
            Carga = Carga;
        }

        public virtual double CalcularSalario(double salario)
        {
            return salario;
        }
    }
}
