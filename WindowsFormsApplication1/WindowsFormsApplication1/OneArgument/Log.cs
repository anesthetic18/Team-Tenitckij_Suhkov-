using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Log : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
