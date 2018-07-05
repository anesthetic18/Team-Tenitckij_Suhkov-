using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Sin : ICalculateOneArgument
    {
        /// <summary>
        /// Calculation function Sin
        /// </summary>
        /// <param name="argument">
        /// The Sin is calculated
        /// </param>
        /// <returns>
        /// Return Sin(x)
        /// </returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
