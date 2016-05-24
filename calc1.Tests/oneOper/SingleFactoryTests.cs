using System;
using calc1.oneOper;
using calc1.twoOper;
using NUnit.Framework;

namespace calc1.Tests.oneOper
{
    public class SingleFactoryTests
    {
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("log", typeof(Log))]
        [TestCase("tan", typeof(Tan))]
        public void AddTest(string name, Type type)
        {
            ISingleCalculator calculate = SingleFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculate);
        } 
    }
}