using System;

namespace WindowsFormsApplication1
{
    public class Ctan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return 1f / Math.Tan(argument);
        }
    }
}
