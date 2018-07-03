using System;

namespace WindowsFormsApplication1
{
    public class Atan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}
