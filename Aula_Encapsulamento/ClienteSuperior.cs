using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ClienteSuperior
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteSuperior(int id, string nome, string endereco)
        {
            DomainExceptionVlidation.When(id < 0, "Id inválido");
            DomainExceptionVlidation.When(string.IsNullOrEmpty(nome), "Nome inválido");
            DomainExceptionVlidation.When(string.IsNullOrEmpty(endereco), "Endereço inválido");

            Id = id;
            Nome = nome;
            Endereco = endereco;
            { 
            }
        }
    }
}
