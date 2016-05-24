using calc1.oneOper;
using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.oneOper
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(2, -0.41614)]
        [TestCase(3, -0.98999)]
        public void CosTest(double first, double expected)
        {
            ISingleCalculator calculate = new Cos();
            double result = calculate.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
