namespace Visitor
{
    internal class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int resultadoEsquerda = Esquerda.Avalia();
            int resultadoDireita = Direita.Avalia();
            return resultadoEsquerda + resultadoDireita;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}