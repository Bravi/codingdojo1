using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class MoneyWriter
    {
        private string prefixo;

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

        public string RetornaValorPorExtenso(int quantidade)
        {
            if (quantidade == 0)
                throw new ArgumentException("Valor não pode ser zero");

            quantidadeTotal = quantidade;

            TratarQuantidadeNegativa(ref quantidade, ref prefixo);

            string valor = ObterValorPelaQuantidade(quantidade);

            return Capitalise(string.Format("{0}{1} {2}", prefixo, valor, ObterExtensoPelaQuantidade(quantidade)));
        }

        private int quantidadeTotal;
        private string ObterValorPelaQuantidade(int quantidade)
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
                    ObterValorPelaQuantidade(RetornarParteDecimal(quantidade)));
            }

            if (quantidade > 200 && quantidade < 1000)
            {
                return string.Format("{0} e {1}",
                    ObterValorPelaQuantidade(RetornarParteCentena(quantidade)),
                    ObterValorPelaQuantidade(RetornarParteDecimal(quantidade)));
            }

            throw new ArgumentException(quantidade.ToString(), "quantidade");
        }

        private int RetornarParteCentena(int quantidade)
        {
            return Convert.ToInt32((quantidade / 100) * 100);
        }

        private int RetornarParteDecimal(int quantidade)
        {
            var auxQtde = Convert.ToDecimal(quantidade) / Convert.ToDecimal(100);
            var result = Convert.ToInt32(((auxQtde - Math.Truncate(auxQtde)) * 100));
            return Math.Abs(result);
        }

        private string ObterExtensoPelaQuantidade(int quantidade)
        {
            return quantidade > 1 ? "reais" : "real";
        }

        private void TratarQuantidadeNegativa(ref int quantidade, ref string prefixo)
        {
            if (quantidade < 0)
            {
                prefixo = "Menos ";
                quantidade = Math.Abs(quantidade);
            }
        }

        private string Capitalise(string str)
        {
            if (String.IsNullOrEmpty(str))
                return String.Empty;
            return Char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }
}
