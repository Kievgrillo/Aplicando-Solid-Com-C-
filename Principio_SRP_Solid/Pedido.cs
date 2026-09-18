using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Principio_SRP_Solid
{
    public class Pedido
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        private EnviarEmail enviaEmail;
        private RegistraLog infoLogger;

        public Pedido()
        {
            enviaEmail = new EnviarEmail();
            infoLogger = new RegistraLog();
        }

        public void IncluirPedido()
        {
            try
            {
                infoLogger.info("Iniciando inclusão de pedido...");
                enviaEmail.EMailFrom = "pedido@exemplo.com";
                enviaEmail.EMailTo = "cliente@exemplo.com";
                enviaEmail.EMailSubject = "Novo Pedido";
                enviaEmail.EMailBody = "Detalhes do pedido...";
                enviaEmail.Enviar();
            }
            catch (Exception ex)
            {
                infoLogger.info($"Erro ao incluir pedido: {ex.Message}");
                throw;
            }
        }
        public void DeletaPedido()
            {
            try
            {
                //codigo para deletar o pedido
                infoLogger.info("Iniciando exclusão de pedido...");
            }
            catch (Exception ex)
            {
                infoLogger.info($"Erro ao deletar pedido: {ex.Message}");
                throw;
            }
        }
    }
}
