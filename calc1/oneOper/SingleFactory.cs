using System;

namespace calc1.oneOper
{
    public static class SingleFactory
    {
        public static ISingleCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();
                case "log":
                    return new Log();
                case "tan":
                    return new Tan();
                default:
                    throw new ArgumentException("Неизвестная операция", "name");
            }
        }
    }
}
