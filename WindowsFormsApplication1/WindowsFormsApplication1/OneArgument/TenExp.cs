using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class TenExp : ICalculateOneArgument
    {
        /// <summary>
        /// Erection of 10 to the power
        /// </summary>
        /// <param name="argument">
        /// Argument is the degree
        /// </param>
        /// <returns>
        /// Return 10^x
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}
