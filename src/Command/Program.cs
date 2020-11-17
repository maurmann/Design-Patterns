using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command");
            Console.WriteLine("Guardar código para execução posterior");

            Pedido pedido1 = new Pedido("Adriano", 100.0);
            Pedido pedido2 = new Pedido("Sandra", 200.0);

            FilaProcessamento filaProcessamento = new FilaProcessamento();
            filaProcessamento.Adicionar(new PagarPedido(pedido1));
            filaProcessamento.Adicionar(new PagarPedido(pedido2));
            filaProcessamento.Adicionar(new FinalizarPedido(pedido1));
            filaProcessamento.Processar();
        }
    }
}
