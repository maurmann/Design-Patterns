using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IEnviador
    {
        void Envia(IMensagem mensagem);
    }
}
