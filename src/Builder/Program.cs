using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder");
            Console.WriteLine("");


            NotaFiscalBuilder builder = new NotaFiscalBuilder()
                .ParaEmpresa("123.456.789/0001-10", "N2S Software Ltda")
                .ParaDataAtual()
                .ComItem(new ItemDaNota("Notebook", 3500.0))
                .ComItem(new ItemDaNota("Impressora", 1000.0))
                .ComObservacoes("Nota de teste do design pattern builder");


            NotaFiscal notaFiscal = builder.Build();

            Console.WriteLine($"Cnpj: {notaFiscal.Cnpj}");
            Console.WriteLine($"Razao Social: {notaFiscal.RazaoSocial}");
            Console.WriteLine($"Valor Bruto: {notaFiscal.ValorBruto}");
            Console.WriteLine($"Impostos: {notaFiscal.Impostos}");
            Console.WriteLine($"Observacoes: {notaFiscal.Observacoes}");

            Console.ReadKey();
        }
    }
}
