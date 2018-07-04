﻿namespace WindowsFormsApplication1.TwoArgument
{
    public class DifDivision : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return  (firstArgument / secondArgument) - (secondArgument / firstArgument);
        }
    }
}
