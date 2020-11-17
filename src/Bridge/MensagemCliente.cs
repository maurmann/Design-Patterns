using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class MensagemCliente : IMensagem
    {
        public IEnviador Enviador { get; set; }
        public string Nome { get; set; }

        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem do cliente para {0}", Nome);
        }
    }
}
