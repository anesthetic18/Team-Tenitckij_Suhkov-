using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Log : ICalculateOneArgument
    {
        /// <summary>
        /// The function of calculating the logarithm
        /// </summary>
        /// <param name="argument">
        /// Argumeent is a basic of logarithm
        /// </param>
        /// <returns>
        /// Return lg(x)
        /// </returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("does't exsist");
            }
            return Math.Log(argument);
        }
    }
}
