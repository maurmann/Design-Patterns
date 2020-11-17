using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *   Estado         Desconto Adicional
             *   -------------- ------------------
             *   Em Aprovação       5%   
             *   Aprovado           2%
             *   Reprovado          0%
             *   Finalizado         0%
             */ 

            
            Console.WriteLine("State");
            Console.WriteLine("");


            Orcamento orcamento = new Orcamento(5000);

            Console.WriteLine($"Estado: {orcamento.EstadoAtual.ToString()} Valor: {orcamento.Valor}");
            orcamento.AplicaDescontoExtra();
            Console.WriteLine($"Estado: {orcamento.EstadoAtual.ToString()} Valor: {orcamento.Valor}");

            orcamento.Aprova();
            Console.WriteLine($"Estado: {orcamento.EstadoAtual.ToString()} Valor: {orcamento.Valor}");
            orcamento.AplicaDescontoExtra();
            Console.WriteLine($"Estado: {orcamento.EstadoAtual.ToString()} Valor: {orcamento.Valor}");

            orcamento.Finaliza();
            Console.WriteLine($"Estado: {orcamento.EstadoAtual.ToString()} Valor: {orcamento.Valor}");



            Console.ReadKey();
            

        }
    }
}
