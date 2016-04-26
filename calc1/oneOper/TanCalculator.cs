using System;
using calc1.twoOper;

namespace calc1.oneOper
{
    class TanCalculator : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
