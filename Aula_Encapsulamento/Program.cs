using System;

namespace Aula_Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClienteSuperior cliente = new ClienteSuperior(1, "João", "Rua A, 123");

            Console.WriteLine($"{ cliente.Id} {cliente.Nome} {cliente.Endereco}");
            Console.ReadLine();
        }

        private static ClienteLower ClienteTeste() 
        {
        ClienteLower cliente = new ClienteLower();
        cliente.Id = 2;
        cliente.Nome = "Maria";
        cliente.Endereco = "Rua B, 123";
        return cliente;
        }
    }
}