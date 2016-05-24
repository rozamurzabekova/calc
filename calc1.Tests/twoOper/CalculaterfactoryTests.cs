using System;
using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
    public class CalculaterfactoryTests
    {
        [TestCase("plus", typeof(Add))]
        [TestCase("minus", typeof(Subtraction))]
        [TestCase("mul", typeof(Multiplication))]
        [TestCase("div", typeof(Division))]
        public void CreatCalculatorTest(string name, Type type)
        {
            ICalculate calculate = Calculaterfactory.CreatCalculator(name);
            Assert.IsInstanceOf(type, calculate);
        }
    }
}