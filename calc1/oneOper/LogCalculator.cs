using System;
using calc1.twoOper;

namespace calc1.oneOper
{
    class LogCalculator : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
