namespace WindowsFormsApplication1.OneArgument
{
    public class Square : ICalculateOneArgument
    {
        /// <summary>
        /// Function of calculating a square
        /// </summary>
        /// <param name="argument">
        /// Argument squared
        /// </param>
        /// <returns>
        /// Return x^2
        /// </returns>
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}
