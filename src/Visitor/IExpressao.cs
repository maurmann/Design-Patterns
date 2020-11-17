using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IExpressao
    {
        int Avalia();


        void Aceita(ImpressoraVisitor impressora);
    }
}
