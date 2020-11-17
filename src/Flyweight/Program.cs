using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flyweight");

            NotasMusicais notasMusicais = new NotasMusicais();
            List<INota> musica = new List<INota>();

            musica.Add(notasMusicais.Pega("do"));
            musica.Add(notasMusicais.Pega("re"));
            musica.Add(notasMusicais.Pega("mi"));
            musica.Add(notasMusicais.Pega("fa"));
            musica.Add(notasMusicais.Pega("fa"));
            musica.Add(notasMusicais.Pega("fa"));

            Tocador tocador = new Tocador();
            tocador.Toca(musica);

        }
    }
}
