using System;
using calc1.oneOper;

namespace calc1.twoOper
{
    public static class SingleFactory
    {
        public static ISingleCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "sin":
                    return new SinCalculator();
                case "cos":
                    return new CosCalculator();
                case "log":
                    return new LogCalculator();
                case "tan":
                    return new LogCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "name");
            }
        }
    }
}
