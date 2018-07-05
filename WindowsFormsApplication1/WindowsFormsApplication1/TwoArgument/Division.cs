using System;

namespace WindowsFormsApplication1.TwoArgument
{
   public class Division : ICalculateTwoArguments
    {
        /// <summary>
        /// function of division
        /// </summary>
        /// <param name="firstArgument">
        /// first argument - delimoe</param>
        /// <param name="secondArgument">
        /// second argument - delitel'</param>
        /// <returns>
        /// division
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("delenie na 0");
            }
            return firstArgument / secondArgument;
        }
    }
}
