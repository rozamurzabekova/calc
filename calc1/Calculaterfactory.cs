using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc1
{
    public static class Calculaterfactory
    {
        public static ICalculate CreatCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new Add();
                case "-":
                    return new Subtraction();
                case "*":
                    return new Multiplication();
                case "/":
                    return new Division();
                default:
                    throw new ArgumentException("Неизвестная операция", "name");
            }
        }
    }
}
