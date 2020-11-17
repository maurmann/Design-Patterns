using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Design Pattern");

            Orcamento orcamento = new Orcamento(100);

            Console.WriteLine($"Valor do orçamento: {orcamento.Valor}");

            Calculadora calculadora = new Calculadora();

            double icms = calculadora.CalcularImposto(orcamento, new ICMS());
            Console.WriteLine($"Valor do ICMS: {icms}");


            double iss = calculadora.CalcularImposto(orcamento, new ISS());
            Console.WriteLine($"Valor do ISS: {iss}");

            Console.ReadKey();

        }
    }
}
