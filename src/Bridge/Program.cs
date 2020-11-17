using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge");

            MensagemAdministrativa mensagemAdministrativa = new MensagemAdministrativa("Adriano");
            mensagemAdministrativa.Enviador = new EnviaPorSMS();
            mensagemAdministrativa.Envia();
        }
    }
}
