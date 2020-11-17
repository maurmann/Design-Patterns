namespace ChainOfResponsability
{
    public class Calculadora
    {
        public double CalcularDescontos(Orcamento orcamento)
        {
            IDesconto descontonumeroItens = new DescontoNumeroItens();
            IDesconto descontoValor = new DescontoValor();
            IDesconto semDesconto = new SemDesconto();

            descontonumeroItens.Proximo = descontoValor;
            descontoValor.Proximo = semDesconto;

            return descontonumeroItens.Calcular(orcamento);
        }
    }
}
