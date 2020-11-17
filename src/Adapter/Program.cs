using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter");
            Console.WriteLine("Isolar bibliotecas ou codigo legado em classes da aplicacao");

            Cliente cliente = new Cliente();
            cliente.Nome = "José de Silva";
            cliente.Endereco = "Porto Alegre";
            cliente.DataNascimento = new DateTime(1978, 11, 23);

            string xml = new SerializadorDeXml().Serializar(cliente);
            Console.WriteLine(xml);
        }
    }
}
