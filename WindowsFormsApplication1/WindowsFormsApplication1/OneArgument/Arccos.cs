using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Arccos : ICalculateOneArgument
    {
        /// <summary>
        /// Calculation function Arccos
        /// </summary>
        /// <param name="argument"> </param>
        /// The arccosine is calculated
        /// <returns>
        /// Return argument Acos
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument <-1 || argument > 1)
            {
                throw new Exception("does't exsist");
            }
            return Math.Acos(argument);
        }
    }
}
