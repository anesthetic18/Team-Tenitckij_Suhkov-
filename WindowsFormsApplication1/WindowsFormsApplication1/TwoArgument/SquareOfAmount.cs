namespace WindowsFormsApplication1.TwoArgument
{
    public class SquareOfAmount : ICalculateTwoArguments
    {
        /// <summary>
        /// function of square of amount
        /// </summary>
        /// <param name="firstArgument">
        /// first term
        /// </param>
        /// <param name="secondArgument">
        /// second term
        /// </param>
        /// <returns>
        /// (x+y)^2
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument) + (2 * secondArgument * firstArgument)+ (secondArgument * secondArgument);
        }
    }
}
