namespace ChainOfResponsability
{
    public class DescontoValor : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Calcular(orcamento);
        }
    }
}
