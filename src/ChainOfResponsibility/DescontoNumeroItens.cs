namespace ChainOfResponsability
{
    public class DescontoNumeroItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Itens.Count>5)
            {
                return orcamento.Valor * 0.2;
            }

            return Proximo.Calcular(orcamento);
        }
    }
}
