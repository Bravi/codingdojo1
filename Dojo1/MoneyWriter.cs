using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class MoneyWriter
    {
        private string extenso;

        private Dictionary<int, string> numeroUnicos = new Dictionary<int, string>()
            {
                {1, "Um"},
                {2, "Dois"},
                {3, "Três"},
                {4, "Quatro"},
                {5, "Cinco"},
                {6, "Seis"},
                {7, "Sete"},
                {8, "Oito"},
                {9, "Nove"},
                {10, "Dez"},
                {11, "Onze"},
                {12, "Doze"},
                {13, "Treze"},
                {14, "Quatorze"},
                {15, "Quinze"},
                {16, "Dezeseis"},
                {17, "Dezesete"},
                {18, "Dezoito"},
                {19, "Dezenove"},
                {20,"Vinte"},
                {30,"Trinta"},
                {40,"Quarenta"},
                {50,"Cinquenta"},
                {60,"Sessenta"},
                {70,"Setenta"},
                {80,"Oitenta"},
                {90,"Noventa"},
                {100,"Cem"},
                {200,"Duzentos"},
                {300,"Trezentos"},
                {400,"Quatrocentos"},
                {500,"Quinhentos"},
                {600,"Seiscentos"},
                {700,"Setecentos"},
                {800,"Oitocentos"},
                {900,"Novecentos"},
                {1000,"Mil"}
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
            string valor = numeroUnicos[p];

            return string.Format("{0}{1} {2}", prefixo, valor, extenso);
        }
    }
}
