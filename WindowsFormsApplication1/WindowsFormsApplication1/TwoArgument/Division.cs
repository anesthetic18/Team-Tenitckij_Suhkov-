using System;

namespace WindowsFormsApplication1.TwoArgument
{
   public class Division : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("delenie na 0");
            }
            return firstArgument / secondArgument;
        }
    }
}
