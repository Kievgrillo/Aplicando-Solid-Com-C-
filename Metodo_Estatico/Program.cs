using System;

namespace Metodo_Estatico

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma =" + Calculo.Somar(5, 10));
            Console.WriteLine("Subtração =" + Calculo.Subtrair(10, 5));
            Console.ReadLine();
        }
    }
}