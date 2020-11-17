using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class NotasMusicais
    {
        public IDictionary<string, INota> Notas { get; set; }

        public NotasMusicais()
        {
            Notas = new Dictionary<string, INota>();
            Notas.Add("do", new Do());
            Notas.Add("re", new Re());
            Notas.Add("mi", new Mi());
            Notas.Add("fa", new Fa());
            Notas.Add("sol", new Sol());
            Notas.Add("la", new La());
            Notas.Add("si", new Si());
        }

        public INota Pega(string key)
        {
            return Notas[key];
        }
    }
}
