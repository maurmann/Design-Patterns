namespace TemplateMethod
{
    public class ISS : TemplateDescontoCondicional
    {
        protected override double CalcularMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.12;
        }

        protected override double CalcularMinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 1000;
        }
    }
}
