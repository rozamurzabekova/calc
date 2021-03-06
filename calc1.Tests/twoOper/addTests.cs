﻿using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.twoOper
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(1, 1, 2)]
        [TestCase(100, 500, 600)]
        public void AddTest(double first, double second, double expected)
        {
            ICalculate calculate = new Add();
            double result = calculate.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}