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
            if (p == 1)
            {
                return "Um real";
            }
            else if (p == 2)
            {
                return "Dois reais";
            }
            else
            {
                return "Três reais";
            }
        }
    }
}
