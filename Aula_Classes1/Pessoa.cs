using System;

namespace Palavra_This
{
    public class Pessoa
    {
        //field
        public string nome;
        public int idade;
        public string genero;

        //construtor vazio
        public Pessoa()
        {
        }

        //construtor com 1 parâmetro
        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        //construtor com 3 parâmetros
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public void Identificar()
        {
            Console.WriteLine($"Olá, sou o {nome} tenho {idade} anos, sou do sexo {genero}");
        }
    }
}
