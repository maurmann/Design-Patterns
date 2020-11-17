using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public interface IImposto
    {
        double Calcular(Orcamento orcamento);
    }
}
