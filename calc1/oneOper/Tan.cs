using System;
using calc1.twoOper;

namespace calc1.oneOper
{
   public class Tan : ISingleCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
