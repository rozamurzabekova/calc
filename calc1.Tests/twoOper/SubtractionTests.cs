using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
    [TestFixture]
    public class SubtractionTests
    {
        [TestCase(2, 2, 0)]
        [TestCase(600, 300, 300)]
        public void DivisionTest(double first, double second, double expected)
        {
            ICalculate calculate = new Subtraction();
            double result = calculate.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

    }

}

