using System;

namespace Propriedade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("João");
            pessoa.Genero = "Masculino";
            pessoa.Idade = 19;

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
        }
    }
}