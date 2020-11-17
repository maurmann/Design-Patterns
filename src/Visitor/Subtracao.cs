namespace Visitor
{
    internal class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int resultadoEsquerda = Esquerda.Avalia();
            int resultadoDireita = Direita.Avalia();
            return resultadoEsquerda - resultadoDireita;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}