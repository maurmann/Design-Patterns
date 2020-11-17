namespace Visitor
{
    internal class Numero : IExpressao
    {
        

        public int Valor { get; private set; }


        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}