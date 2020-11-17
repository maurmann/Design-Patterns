using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EnviarNotaPorEmail : AcaoAposGerarNota
    {
        public void Executar(NotaFiscal notafiscal)
        {
            Console.WriteLine("Enviando Nota por Email");
        }
    }
}
