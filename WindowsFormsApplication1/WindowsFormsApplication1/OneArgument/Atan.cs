using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Atan : ICalculateOneArgument
    {
        /// <summary>
        /// Arctan calculation function
        /// </summary>
        /// <param name="argument">
        /// The arctan is calculated
        /// </param>
        /// <returns>
        /// Return Atan(x)
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}
