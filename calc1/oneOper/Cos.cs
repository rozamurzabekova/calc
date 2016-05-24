using System;

namespace calc1.oneOper
{
    public class Cos : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
