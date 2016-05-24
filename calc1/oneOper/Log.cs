using System;
using calc1.twoOper;

namespace calc1.oneOper
{
    public class Log : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
