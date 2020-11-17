using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface AcaoAposGerarNota
    {
        void Executar(NotaFiscal notafiscal);
    }
}
