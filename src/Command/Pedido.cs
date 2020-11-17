using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Command
{
    public class Pedido
    {

        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public State State { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            State = State.Novo;
        }

        public void Pagar()
        {
            State = State.Pago;
        }

        public void Finalizar()
        {
            State = State.Finalizado;
            DataFinalizacao = DateTime.Now;
        }
    }
}
