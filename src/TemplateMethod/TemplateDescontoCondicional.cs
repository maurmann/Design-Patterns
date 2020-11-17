using System;

namespace TemplateMethod
{
    public abstract class TemplateDescontoCondicional : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return CalcularMaximaTaxacao(orcamento);
            }
            return CalcularMinimaTaxacao(orcamento);
        }
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double CalcularMaximaTaxacao(Orcamento orcamento);
        protected abstract double CalcularMinimaTaxacao(Orcamento orcamento);
    }
}
