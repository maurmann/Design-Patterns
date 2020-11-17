using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("NOTEBOOK", 1500));
            orcamento.AdicionaItem(new Item("MOUSE", 100));
            orcamento.AdicionaItem(new Item("TECLADO", 100));
            orcamento.AdicionaItem(new Item("MONITOR", 100));
            orcamento.AdicionaItem(new Item("IMPRESSORA", 100));
            orcamento.AdicionaItem(new Item("BATERIA", 100));

            Calculadora calculadora = new Calculadora();
            double desconto = calculadora.CalcularDescontos(orcamento);

            Console.WriteLine($"Valor: {orcamento.Valor}");
            Console.WriteLine($"Desconto: {desconto}");

            Console.ReadKey();
        }
    }
}
