using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void BasikTest()
        {
            ICalculate calculate = new Division();
            double result = calculate.Calculate(1, 1);
            Assert.AreEqual(1, result);
        }
    }
}