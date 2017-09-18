using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestSummary1()
        {
            Assert.AreEqual(10, Calc.Summary(7.3, 2.7));
        }
        [Test]
        public void TestSummary2()
        {
            Assert.AreEqual(534, Calc.Summary(501, 33));
        }
        [Test]
        public void TestSummary3()
        {
            Assert.AreEqual(73458, Calc.Summary(30257, 43201));

        }
        [Test]
        public void TestSummary4()
        {
            Assert.AreEqual(436723489, Calc.Summary(12347647, 424375842));
        }
        [Test]
        public void TestSummary5()
        {
            Assert.AreEqual(5576, Calc.Summary(4346, 1230));
        }

        [Test]
        public void TestMinus1()
        {
            Assert.AreEqual(10.55, Calc.Minus(17.3, 6.75));
        }

        [Test]
        public void TestMinus2()
        {
            Assert.AreEqual(-45, Calc.Minus(100, 145));
        }

        [Test]
        public void TestMinus3()
        {
            Assert.AreEqual(655, Calc.Minus(800, 145));
        }

        [Test]
        public void TestMinus4()
        {
            Assert.AreEqual(7324, Calc.Minus(5374, -1950));
        }

        [Test]
        public void TestMinus5()
        {
            Assert.AreEqual(6744, Calc.Minus(10044, 3300));
        }

        [Test]
        public void TestMultiply1()
        {
            Assert.AreEqual(14500, Calc.Multiply(-100, -145));
        }
        [Test]
        public void TestMultiply2()
        { 
            Assert.AreEqual(1818.1499999999999, Calc.Multiply(25.5, 71.3));
        }
        [Test]
        public void TestMultiply3()
        {
            Assert.AreEqual(-14500, Calc.Multiply(-100, 145));
        }
        [Test]
        public void TestMultiply4()
        {
            Assert.AreEqual(500, Calc.Multiply(1000, 0.5));
        }
        [Test]
        public void TestMultiply5()
        {
            Assert.AreEqual(4776548, Calc.Multiply(51919, 92));
        }

        [Test]
        public void TestDivision1()
        {
            Assert.AreEqual(100, Calc.Division(-14500, -145));
        }
        [Test]
        public void TestDivision2()
        {
            Assert.AreEqual(4.9708108108108107, Calc.Division(459.8, 92.5));
        }
        [Test]
        public void TestDivision3()
        {
            Assert.AreEqual(-700154, Calc.Division(-63714014, 91));
        }
        [Test]
        public void TestDivision4()
        {
            Assert.AreEqual(15.997417688831504, Calc.Division(9912, 619.6));
        }
        [Test]
        public void TestDivision5()
        {
            Assert.AreEqual(654864, Calc.Division(270458832, 413));
        }
    }
}
