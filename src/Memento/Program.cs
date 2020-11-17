using System;
using System.Threading;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento");

            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Adriano", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvarEstado());

            Thread.Sleep(500);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvarEstado());

            Thread.Sleep(500);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvarEstado());



            Estado e0 = historico.Obter(0);
            Console.WriteLine($"Estado {0} em {e0.DataTransicao} com tipo {e0.Contrato.Tipo}");


            Estado e1 = historico.Obter(1);
            Console.WriteLine($"Estado {1} em {e1.DataTransicao} com tipo {e1.Contrato.Tipo}");


            Estado e2 = historico.Obter(2);
            Console.WriteLine($"Estado {2} em {e1.DataTransicao} com tipo {e2.Contrato.Tipo}");


        }
    }
}
