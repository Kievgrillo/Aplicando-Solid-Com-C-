namespace Principio_ISP
{
    class CadastrarCliente : IPersistencia, IEnviarEmail
    {
        public void ValidarDados()
        {
            Console.WriteLine("Validar dados");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar dados");
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Enviar email");
        }
    }
}
