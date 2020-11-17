using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interpreter");

            // (1+10) + (20-10)

            IExpressao  esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma =   new Soma(esquerda, direita);
            int resultado = soma.Avalia();
            Console.WriteLine(resultado);

        }
    }
}
