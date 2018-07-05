namespace WindowsFormsApplication1.TwoArgument
{
    public class Multiplication : ICalculateTwoArguments
    {
        /// <summary>
        /// function of multiplication
        /// </summary>
        /// <param name="firstArgument">
        /// first multiplier
        /// </param>
        /// <param name="secondArgument">
        /// second multiplier
        /// </param>
        /// <returns>
        /// x*y
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
