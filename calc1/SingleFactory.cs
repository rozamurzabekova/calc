using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc1
{
    public static class SingleFactory
    {
        public static ISingleCalculator CreatCalculator(string name)
        {
            switch (name)
            {
                case "sin":
                    return new SinCalculator();
                case "cos":
                    return new CosCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "name");
            }
        }
    }
}
