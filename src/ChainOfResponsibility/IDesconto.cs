using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public interface IDesconto
    {
        double Calcular(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
