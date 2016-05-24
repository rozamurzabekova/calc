using System;
using calc1.twoOper;

namespace calc1.oneOper
{
    public class Sin : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
