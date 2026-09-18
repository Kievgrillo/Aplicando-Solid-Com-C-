namespace Principio_OCP_Solid
{
    public class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double ValorFinal)
        {
            return ValorFinal - 10;         }
    }
}
