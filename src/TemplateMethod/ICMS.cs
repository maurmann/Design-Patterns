namespace TemplateMethod
{
    public class ICMS : TemplateDescontoCondicional
    {
        protected override double CalcularMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double CalcularMinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 5000 && orcamento.Itens.Count > 5;
        }
    }
}
