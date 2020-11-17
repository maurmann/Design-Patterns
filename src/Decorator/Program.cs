using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator");

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("NOTEBOOK", 1500));
            orcamento.AdicionaItem(new Item("MOUSE", 100));
            orcamento.AdicionaItem(new Item("TECLADO", 100));
            orcamento.AdicionaItem(new Item("MONITOR", 100));
            orcamento.AdicionaItem(new Item("IMPRESSORA", 100));
            orcamento.AdicionaItem(new Item("BATERIA", 100));


            Console.WriteLine($"Orçamento: {orcamento.Valor}");

            ICMS icms = new ICMS();
            Console.WriteLine($"ICMS {icms.Calcula(orcamento)}");

            ISS iss = new ISS();
            Console.WriteLine($"ISS {iss.Calcula(orcamento)}");

            // Vai calcular o ICMS somando o valor do ISS
            // O ISS como não recebe outro imposto calcula apenas seu proprio valor
            ICMS icmsMaisISS = new ICMS(new ISS());
            Console.WriteLine($"ICMS + com ISS: {icmsMaisISS.Calcula(orcamento)}  <-- ICMS decorado com ISS!");
 
            Console.ReadKey();
        }
    }
}
