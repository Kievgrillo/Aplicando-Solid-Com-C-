using System;

namespace Assembly2
{
    class Teste
    {
        public string Nome { get; set; }
        public Teste(Exemplo exemplo)
        {
            //Usa o nome da instancia
            this.Nome = exemplo.Nome;
            Console.WriteLine($"Nome do exemplo: {this.Nome}");
        }
    }

    class Exemplo
    {
        public string Nome { get; set; }

        public Exemplo(string Nome)
        {
            this.Nome = Nome;
            //passa a isntancia this como parametro 
            Teste teste = new Teste(this);
            //a iusntancia teste agora possui o mesmo nome
            Console.WriteLine($"Nome do funcionario: {teste.Nome}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Exemplo exemplo = new Exemplo("This");
                Console.ReadLine();
            }
        }
    }
}
