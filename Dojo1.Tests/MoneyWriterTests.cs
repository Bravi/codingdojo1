using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Dojo1.Tests
{
    [TestFixture]
    public class MoneyWriterTests
    {
        private MoneyWriter writer;
        private object[] dinheiroNumerosUnicos =
            {
                new object[] { 1, "Um real" },
                new object[] { 2, "Dois reais" },
                new object[] { 3, "Três reais" },
                new object[] { 4, "Quatro reais" },
                new object[] { 5, "Cinco reais" },
                new object[] { 6, "Seis reais" },
                new object[] { 7, "Sete reais" },
                new object[] { 8, "Oito reais" },
                new object[] { 9, "Nove reais" },
                new object[] { 10, "Dez reais" },
                new object[] { 11, "Onze reais" },
                new object[] { 12,"Doze reais" },
                new object[] { 13, "Treze reais" },
                new object[] { 14, "Quatorze reais" },
                new object[] { 15, "Quinze reais" },
                new object[] { 16, "Dezeseis reais" },
                new object[] { 17, "Dezesete reais" },
                new object[] { 18, "Dezoito reais" },
                new object[] { 19, "Dezenove reais" },
                new object[] { 20, "Vinte reais" },
                new object[] {30 , "Trinta reais" },
                new object[] { 40 , "Quarenta reais" },
                new object[] { 50 , "Cinquenta reais" },
                new object[] { 60 , "Sessenta reais" },
                new object[] { 70 , "Setenta reais" },
                new object[] { 80 , "Oitenta reais" },
                new object[] { 90 , "Noventa reais" },
                new object[] { 100 , "Cem reais" },
                new object[] { 200 , "Duzentos reais" },
                new object[] { 300 , "Trezentos reais" },
                new object[] { 400 , "Quatrocentos reais" },
                new object[] { 500 , "Quinhentos reais" },
                new object[] { 600 , "Seiscentos reais" },
                new object[] { 700 , "Setecentos reais" },
                new object[] { 800 , "Oitocentos reais" },
                new object[] { 900 , "Novecentos reais" },
                new object[] { 1000 , "Mil reais" }
            };


        [SetUp]
        public void Setup()
        {
            writer = new MoneyWriter();
        }

        [TestCaseSource("dinheiroNumerosUnicos")]
        public void Para_Numeros_Unicos_Retornar_Valor_Por_Extenso(int valor, string extenso)
        {
            string porextenso = writer.RetornaValorPorExtenso(valor);

            Assert.That(porextenso, Is.EqualTo(extenso));
        }

        [Test]
        public void DeveLancarExcecaoParaZero()
        {
            Assert.Throws<ArgumentException>(() => writer.RetornaValorPorExtenso(0));
        }


        [Test]
        public void Para_Valores_Negativos_Coloca_Prefixo_Menos()
        {
            string porextenso = writer.RetornaValorPorExtenso(-2);

            Assert.That(porextenso, Is.EqualTo("Menos Dois reais"));
        }
    }
}
