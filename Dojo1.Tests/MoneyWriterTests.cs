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

        [SetUp]
        public void Setup()
        {
            writer = new MoneyWriter();
        }

        [TestCase(1, "Um real")]
        [TestCase(2, "Dois reais")]
        [TestCase(3, "Três reais")]
        [TestCase(4, "Quatro reais")]
        [TestCase(5, "Cinco reais")]
        [TestCase(6, "Seis reais")]
        [TestCase(7, "Sete reais")]
        [TestCase(8, "Oito reais")]
        [TestCase(9, "Nove reais")]
        public void Para_Numeros_Inteiros_Deve_Retornar_Por_Extenso(int valor, string extenso)
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
