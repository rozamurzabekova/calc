using System;
using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(600, 200, 3)]
        public void DivisionTest(double first, double second, double expected)
        {
            ICalculate calculate = new Division();
            double result = calculate.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionbyZeroTest()
        {
            ICalculate calculate = new Division();
            Assert.Throws<Exception>(() => calculate.Calculate(45, 0));
        }
    }
}