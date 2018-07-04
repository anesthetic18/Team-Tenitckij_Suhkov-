using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Arccos : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Acos(argument);
        }
    }
}
