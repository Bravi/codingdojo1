using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo1
{
    public class ConversorMonetarioParaExtenso
    {
        ConversorNumericoParaExtenso conversorNumericoParaExtenso;

        public ConversorMonetarioParaExtenso(ConversorNumericoParaExtenso conversorNumericoParaExtenso)
        {
            this.conversorNumericoParaExtenso = conversorNumericoParaExtenso;
        }

        public string RetornaValorPorExtenso(int quantidade)
        {
            if (quantidade == 0)
                throw new ArgumentException("Valor não pode ser zero");

            string prefixo;
            TratarQuantidadeNegativa(ref quantidade, out prefixo);

            string valor = conversorNumericoParaExtenso.ObterValorPelaQuantidade(quantidade);

            return Capitalise(string.Format("{0}{1} {2}", prefixo, valor, ObterExtensoPelaQuantidade(quantidade)));
        }

        private string ObterExtensoPelaQuantidade(int quantidade)
        {
            return quantidade > 1 ? "reais" : "real";
        }

        private void TratarQuantidadeNegativa(ref int quantidade, out string prefixo)
        {
            prefixo = string.Empty;
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
