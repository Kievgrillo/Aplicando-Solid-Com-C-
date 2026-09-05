using System;

namespace Sobrecarga_Com_Metodo
{
    public class Cliente
    {
        public void Sobrecarga()
        {
        }
        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }
        static public double Somar(double numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public int Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (var numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            {
                var resultado1 = Somar(10, 20);
                var resultado2 = Somar(10, 20, 30);
                var resultado3 = Somar(10.5, 20);
                var resultado4 = Somar(10, 20, 30, 40);

                Console.WriteLine($"Resultado 1: {resultado1}");
                Console.WriteLine($"Resultado 2: {resultado2}");
                Console.WriteLine($"Resultado 3: {resultado3}");
                Console.WriteLine($"Resultado 4: {resultado4}");

                Console.ReadLine();
            }
        }
    }
}