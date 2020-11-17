using System.Collections.Generic;

namespace Memento
{
    class Historico
    {
        public IList<Estado> Estados { get; private set; }

        public Historico()
        {
            Estados = new List<Estado>();
        }

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }

        public Estado Obter(int indice)
        {
            return Estados[indice];
        }
    }
}
