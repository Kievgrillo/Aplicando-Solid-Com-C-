namespace HerancaDois
{
    public class Veiculo
    {
        private string _numeroChassi;
        public Veiculo()
        {
            Console.WriteLine("Inicializando Veículo");
        }

        public Veiculo(string numeroChassi)
        {
            _numeroChassi = numeroChassi;
            Console.WriteLine("Inicializando Veículo com Chassi: " + numeroChassi);
        }
    }
}
