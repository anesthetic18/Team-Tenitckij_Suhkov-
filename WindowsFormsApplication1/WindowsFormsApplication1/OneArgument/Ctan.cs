using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Ctan : ICalculateOneArgument
    {
        /// <summary>
        /// Calculation function Ctan
        /// </summary>
        /// <param name="argument">
        /// The Ctan is calculated
        /// </param>
        /// <returns>
        /// Return the Ctan argument
        /// </returns>
        public double Calculate(double argument)
        {
            return 1f / Math.Tan(argument);
        }
    }
}
