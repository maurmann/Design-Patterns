using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class PagarPedido : IComando
    {
        private Pedido Pedido { get; set; }

        public PagarPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando pedido do cliente {0}", Pedido.Cliente);
            Pedido.Pagar();
        }
    }
}
