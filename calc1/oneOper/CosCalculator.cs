using System;
using calc1.twoOper;

namespace calc1.oneOper
{
    class CosCalculator : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
