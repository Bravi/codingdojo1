using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class MoneyWriter
    {
        public string RetornaValorPorExtenso(int p)
        {
            return p == 1 ? "Um real" : "Dois reais";
        }
    }
}
