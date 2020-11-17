using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    // A classe estado não é obrigatória, pode ser utilizada para encapsular o tipo a ter o estado preservado
    // e também para armazenar informacoes adicionais, como a data e hora do estado
    class Estado
    {
        public Contrato Contrato { get; private set; }
        public DateTime DataTransicao { get; private set; }

        public Estado(Contrato contrato)
        {
            Contrato = contrato;
            DataTransicao = DateTime.Now;
        }
    }
}
