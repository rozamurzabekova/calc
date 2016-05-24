using calc1.oneOper;
using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.oneOper
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(2, -2.18503)]
        [TestCase(3, -0.14254)]
        public void TanTest(double first, double expected)
        {
            ISingleCalculator calculate = new Tan();
            double result = calculate.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
