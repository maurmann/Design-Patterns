using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsability
{
    public class Orcamento
    {
        public IList<Item> Itens { get; private set; }
        public double Valor { get { return Itens.Sum(x => x.Valor); } }

        public Orcamento()
        {
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
        
    }
}
