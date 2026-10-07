using System;

namespace Principio_ISP
{
    class CadastrarProduto : IPersistencia
    {
        public void ValidarDados()
        {
            Console.WriteLine("Validar dados");
        }
        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar dados");
        }
    }
}
