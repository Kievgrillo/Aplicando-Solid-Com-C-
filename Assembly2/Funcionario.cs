 using System;
using System.Collections.Generic;
using System.Text;

namespace Assembly2
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }    

    public Funcionario(string Nome, string Email)
        {
            //usando this para qualificar as propriedades evitando ambiguidade com os parametro usandos no construtor
            this.Nome = Nome;
            this.Email = Email;
        }
    }

    }

