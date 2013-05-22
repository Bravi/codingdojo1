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
        [Test]
        public void Para_1_Deve_Retornar_Um_Real()
        {
            MoneyWriter writer = new MoneyWriter();
            string porextenso = writer.RetornaValorPorExtenso(1);

            Assert.That(porextenso, Is.EqualTo("Um real"));
        }

        [Test]
        public void Para_2_Deve_Retornar_Dois_Reais()
        {
            MoneyWriter writer = new MoneyWriter();
            string porextenso = writer.RetornaValorPorExtenso(2);

            Assert.That(porextenso, Is.EqualTo("Dois reais"));
        }

        [Test]
        public void Para_3_Deve_Retornar_Tres_Reais()
        {
            MoneyWriter writer = new MoneyWriter();
            string porextenso = writer.RetornaValorPorExtenso(3);

            Assert.That(porextenso, Is.EqualTo("Três reais"));
        }
    }
}
