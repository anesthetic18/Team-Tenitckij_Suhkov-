namespace WindowsFormsApplication1.OneArgument
{
    public class Fraction : ICalculateOneArgument
    {
        /// <summary>
        /// Function of calculating a fraction
        /// </summary>
        /// <param name="argument">
        /// Argument is a denominator
        /// </param>
        /// <returns>
        /// Return 1/x
        /// </returns>
        public double Calculate(double argument)
        {
            return 1/argument;
        }
    }
}
