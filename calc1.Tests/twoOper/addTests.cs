using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
[TestFixture]
    public class addTests
    {
    [Test]
    public void BasikTest()
    {
        ICalculate calculate=new Add();
        double result = calculate.Calculate(1, 1);
        Assert.AreEqual(2, result);
    }
    }
}