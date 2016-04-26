using System;

namespace calc1.twoOper
{
    public static class Calculaterfactory
    {
        public static ICalculate CreatCalculator(string name)
        {
            switch (name)
            {
                case "plus":
                    return new Add();
                case "minus":
                    return new Subtraction();
                case "mul":
                    return new Multiplication();
                case "div":
                    return new Division();
                default:
                    throw new ArgumentException("Неизвестная операция", "name");
            }
        }
    }
}
