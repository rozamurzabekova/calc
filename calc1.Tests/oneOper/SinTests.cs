using calc1.oneOper;
using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.oneOper
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(1, 0.84147)]
        [TestCase(5, -0.95892)]
        public void SinTest(double first, double expected)
        {
            ISingleCalculator calculate = new Sin();
            double result = calculate.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
