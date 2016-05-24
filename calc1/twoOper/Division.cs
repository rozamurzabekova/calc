using System;

namespace calc1.twoOper
{
    public class Division: ICalculate
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("деление на ноль");
            }
            return first / second;
        }
    }
}
