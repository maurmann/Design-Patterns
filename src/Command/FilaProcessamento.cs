using System.Collections.Generic;

namespace Command
{
    internal class FilaProcessamento
    {
        private IList<IComando> comandos;

        public FilaProcessamento()
        {
            comandos = new List<IComando>();
        }

        public void Adicionar(IComando comando)
        {
            comandos.Add(comando);
        }

        public void Processar()
        {

            foreach (IComando comando in comandos)
            {
                comando.Executa();
            }

        }

    }
}
