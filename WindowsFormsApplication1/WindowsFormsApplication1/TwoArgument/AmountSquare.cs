namespace WindowsFormsApplication1.TwoArgument
{
    public class AmountSquare : ICalculateTwoArguments
    {
        /// <summary>
        /// function of amount of square
        /// </summary>
        /// <param name="firstArgument">
        /// first argument</param>
        /// <param name="secondArgument">
        /// second argument</param>
        /// <returns>
        /// amount of square
        /// </returns>
        public double Calculate (double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument + secondArgument * secondArgument);
        }
    }
}
