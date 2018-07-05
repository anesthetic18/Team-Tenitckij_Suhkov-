using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Tan : ICalculateOneArgument
    {
        /// <summary>
        /// Calculation function Tan
        /// </summary>
        /// <param name="argument">
        /// The Tan is calculated
        /// </param>
        /// <returns>
        /// Return Tan(x)
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
