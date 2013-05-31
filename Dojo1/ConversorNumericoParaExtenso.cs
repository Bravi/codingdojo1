using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class ConversorNumericoParaExtenso
    {
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

        public string ObterValorPelaQuantidade(int quantidade)
        {
            string valor;
            if (numeroUnicos.TryGetValue(quantidade, out valor))
                return valor;

            if (quantidade > 20 && quantidade < 100)
            {
                return string.Format("{0} e {1}",
                    ObterValorPelaQuantidade((int)(quantidade / 10) * 10),
                    ObterValorPelaQuantidade(quantidade % 10));
            }

            if (quantidade > 100 && quantidade < 200)
            {
                return string.Format("Cento e {0}",
                    ObterValorPelaQuantidade(RetornarParteDezena(quantidade)));
            }

            if (quantidade > 200 && quantidade < 1000)
            {
                return string.Format("{0} e {1}",
                    ObterValorPelaQuantidade(RetornarParteCentena(quantidade)),
                    ObterValorPelaQuantidade(RetornarParteDezena(quantidade)));
            }

            throw new ArgumentException(quantidade.ToString(), "quantidade");
        }

        private double ConverterParaBase100(int quantidade)
        {
            return Convert.ToDouble(quantidade) / 100.0;
        }

        private int RetornarParteCentena(int quantidade)
        {
            return (int)Math.Truncate(ConverterParaBase100(quantidade)) * 100;
        }

        private int RetornarParteDezena(int quantidade)
        {
            var auxQtde = ConverterParaBase100(quantidade);
            var result = Convert.ToInt32((auxQtde - Math.Floor(auxQtde)) * 100);
            return Math.Abs(result);
        }

        public void TratarQuantidadeNegativa(ref int quantidade, out string prefixo)
        {
            prefixo = string.Empty;
            if (quantidade < 0)
            {
                prefixo = "Menos ";
                quantidade = Math.Abs(quantidade);
            }
        }
    }
}
