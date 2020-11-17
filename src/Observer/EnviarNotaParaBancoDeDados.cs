using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EnviarNotaParaBancoDeDados : AcaoAposGerarNota
    {
        public void Executar(NotaFiscal notafiscal)
        {
            Console.WriteLine("Enviando Nota para Banco de Dados");
        }
    }
}
