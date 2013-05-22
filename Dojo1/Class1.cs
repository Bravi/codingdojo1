using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class MoneyWriter
    {
        private string extenso;

        private Dictionary<int, string> meuDicionario = new Dictionary<int, string>()
            {
                {1, "Um"},
                {2, "Dois"},
                {3, "Três"},
                {4, "Quatro"},
                {5, "Cinco"},
                {6, "Seis"},
                {7, "Sete"},
                {8, "Oito"},
                {9, "Nove"}
            };

        public string RetornaValorPorExtenso(int p)
        {
            if (p == 0)
                throw new ArgumentException("Valor não pode ser zero");

            var prefixo = "";
            if (p < 0)
            {
                prefixo = "Menos ";
                p = p * -1;
            }
            extenso = p > 1 ? "reais" : "real";
            string valor = meuDicionario[p];

            return string.Format("{0}{1} {2}", prefixo, valor, extenso);
        }
    }
}
