﻿namespace WindowsFormsApplication1.TwoArgument
{
    public class Subtraction : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
