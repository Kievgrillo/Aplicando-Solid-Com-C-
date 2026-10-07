using System;

namespace Principio_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("João", "40h");
            Console.WriteLine($"Salário do funcionário: {funcionario.CalcularSalario(2000)}");
            Vendedor vendedor = new Vendedor("Maria", "40h");
            vendedor.Comissao = 500;
            Console.WriteLine($"Salário do vendedor: {vendedor.CalcularSalario(2000)}");
            Gerente gerente = new Gerente("Carlos", "40h");
            gerente.Bonus = 1000;
            Console.WriteLine($"Salário do gerente: {gerente.CalcularSalario(2000)}");
        }
    }
}