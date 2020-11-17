using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Tocador
    {

        public void Toca(List<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 500);
            }
        }
    }
}
