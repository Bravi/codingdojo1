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

        private object[] dinheiroNumerosNaoUnicos =
            {
                new object[] { 21, "Vinte e um reais" },
                new object[] { 29, "Vinte e nove reais" },
                new object[] { 31, "Trinta e um reais" },
                new object[] { 39, "Trinta e nove reais" },
                new object[] { 41, "Quarenta e um reais" },
                new object[] { 49, "Quarenta e nove reais" },
                new object[] { 51, "Cinquenta e um reais" },
                new object[] { 59, "Cinquenta e nove reais" },
                new object[] { 61, "Sessenta e um reais" },
                new object[] { 69, "Sessenta e nove reais" },
                new object[] { 71, "Setenta e um reais" },
                new object[] { 79, "Setenta e nove reais" },
                new object[] { 81, "Oitenta e um reais" },
                new object[] { 89, "Oitenta e nove reais" },
                new object[] { 91, "Noventa e um reais" },
                new object[] { 99, "Noventa e nove reais" },
                new object[] { 101, "Cento e um reais" },
                new object[] { 102, "Cento e dois reais" },
                new object[] { 110, "Cento e dez reais" },
                new object[] { 111, "Cento e onze reais" },
                new object[] { 122, "Cento e vinte e dois reais" },
                new object[] { 123, "Cento e vinte e três reais" },
                new object[] { 134, "Cento e trinta e quatro reais" },
                new object[] { 245, "Duzentos e quarenta e cinco reais" },
                new object[] { 356 , "Trezentos e cinquenta e seis reais" },
                new object[] { 467 , "Quatrocentos e sessenta e sete reais" },
                new object[] { 578 , "Quinhentos e setenta e oito reais" },
                new object[] { 689 , "Seiscentos e oitenta e nove reais" },
                new object[] { 701 , "Setecentos e um reais" },
                new object[] { 823 , "Oitocentos e vinte e três reais" },
                new object[] { 999 , "Novecentos e noventa e nove reais" }
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

        [TestCaseSource("dinheiroNumerosNaoUnicos")]
        public void Para_Numeros_Nao_Unicos_Retornar_Valor_Por_Extenso(int valor, string extenso)
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

            Assert.That(porextenso, Is.EqualTo("Menos dois reais"));
        }
    }
}
