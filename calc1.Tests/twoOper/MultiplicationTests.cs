using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(3, 3, 9)]
        [TestCase(2, 5, 10)]
        public void DivisionTest(double first, double second, double expected)
        {
            ICalculate calculate = new Multiplication();
            double result = calculate.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}