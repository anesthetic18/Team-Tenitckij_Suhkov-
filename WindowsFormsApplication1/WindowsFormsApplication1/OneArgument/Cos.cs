using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Cos : ICalculateOneArgument
    {
        /// <summary>
        /// Calculation function Cos
        /// </summary>
        /// <param name="argument">
        /// The Cos is calculated
        /// </param>
        /// <returns>
        /// Return Cos(x)
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
