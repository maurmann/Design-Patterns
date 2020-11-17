using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Orcamento
    {

        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicarDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

    }
}
