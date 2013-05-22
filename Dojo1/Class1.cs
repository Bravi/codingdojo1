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
                case 4:
                    valor = "Quatro";
                    break;
                case 5:
                    valor = "Cinco";
                    break;
                case 6:
                    valor = "Seis";
                    break;
                case 7:
                    valor = "Sete";
                    break;
                case 8:
                    valor = "Oito";
                    break;
                case 9:
                    valor = "Nove";
                    break;
            }

            return string.Format("{0} {1}", valor, extenso);
        }
    }
}
