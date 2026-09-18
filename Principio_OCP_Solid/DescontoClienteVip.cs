namespace Principio_OCP_Solid
{
    public class DescontoClienteVip : Pedido
    {
        public override double DescontoPedido(double ValorFinal)
        {
            return ValorFinal - 30; 
        }
    }
}
 