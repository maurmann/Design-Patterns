using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Method");

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("NOTEBOOK", 1500));
            orcamento.AdicionaItem(new Item("MOUSE", 100));
            orcamento.AdicionaItem(new Item("TECLADO", 100));
            orcamento.AdicionaItem(new Item("MONITOR", 100));
            orcamento.AdicionaItem(new Item("IMPRESSORA", 100));
            orcamento.AdicionaItem(new Item("BATERIA", 100));

            ICMS icms = new ICMS();
            Console.WriteLine($"ICMS: {icms.Calcular(orcamento)}");


            ISS iss = new ISS();
            Console.WriteLine($"ISS: {iss.Calcular(orcamento)}");

            Console.ReadKey();
        }
    }
}
