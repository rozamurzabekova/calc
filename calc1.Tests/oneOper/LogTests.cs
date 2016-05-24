using calc1.oneOper;
using NUnit.Framework;

namespace calc1.Tests.oneOper
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(10, 2.3025)]
        [TestCase(100, 4.6051)]
        public void LogTest(double first, double expected)
        {
            ISingleCalculator calculate = new Log();
            double result = calculate.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}