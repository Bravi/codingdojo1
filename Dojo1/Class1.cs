using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class MoneyWriter
    {
        private string extenso;

        public string RetornaValorPorExtenso(int p)
        {
            extenso = p > 1 ? "reais" : "real";
            string valor = string.Empty;

            switch (p)
            {
                case 1:
                    valor = "Um";
                    break;
                case 2:
                    valor = "Dois";
                    break;
                case 3:
                    valor = "Três";
                    break;
            }

            return string.Format("{0} {1}", valor, extenso);
        }
    }
}
