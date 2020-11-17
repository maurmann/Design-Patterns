using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class MensagemAdministrativa : IMensagem
    {
        public IEnviador Enviador { get; set; }
        public string Nome { get; set; }

        public MensagemAdministrativa(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem administrativa para {0}", Nome);
        }
    }
}
