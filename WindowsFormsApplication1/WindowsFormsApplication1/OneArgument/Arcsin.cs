using System;

namespace WindowsFormsApplication1.OneArgument
{
        public class Arcsin : ICalculateOneArgument
        {
        /// <summary>
        /// Calculation function Arcsin
        /// </summary>
        /// <param name="argument">
        /// The arcsine is calculate
        /// </param>
        /// <returns>
        /// Return argument Asin
        /// </returns>
        public double Calculate(double argument)
            {
                if (argument < -1 || argument > 1)
                {
                    throw new Exception("does't exsist");
                }
            return Math.Asin(argument);
            }
        }
    
}
