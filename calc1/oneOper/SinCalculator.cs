using System;
using calc1.twoOper;

namespace calc1.oneOper
{
    class SinCalculator : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
