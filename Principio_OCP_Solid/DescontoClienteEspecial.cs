namespace Principio_OCP_Solid
{
    public class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double ValorFinal)
        {
            return ValorFinal - 20; 
        }
    }
}
