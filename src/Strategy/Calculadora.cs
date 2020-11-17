namespace Strategy
{
    public class Calculadora
    {
        public double CalcularImposto(Orcamento orcamento,IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
