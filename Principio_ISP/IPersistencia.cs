namespace Principio_ISP
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();

        //void EnviarEmail(); se eu nao criar outra interface para esse metodo, estarei violando o principio ISP,
        //pois a interface IPersistencia nao tem nada a ver com envio de email, entao nao posso colocar esse metodo aqui.
    }
}
