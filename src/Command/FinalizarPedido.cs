using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class FinalizarPedido : IComando
    {

        private Pedido Pedido { get; set; }

        public FinalizarPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", Pedido.Cliente);
            Pedido.Finalizar();
        }
    }
}
