using Principio_OCP_Extensao_Solid.Extension;

namespace Principio_OCP_Extensao_Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(
                1,
                "Caneta",
                "Caneta azul",
                2.00M,
                3.40M,
                100,
                true
                );

            Console.WriteLine($"{produto1.Nome} Lucro = {produto1.MargemLucro():F2}%");

            Console.ReadLine();
        }
    }
}