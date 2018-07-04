using System;

namespace WindowsFormsApplication1
{
        public class Arcsin : ICalculateOneArgument
        {
            public double Calculate(double argument)
            {
                return Math.Asin(argument);
            }
        }
    
}
