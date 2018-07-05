namespace WindowsFormsApplication1.TwoArgument
{
    public class Amount : ICalculateTwoArguments
    {
        /// <summary>
        /// function of amount
        /// </summary>
        /// <param name="firstArgument">
        /// take firstArgument</param>
        /// <param name="secondArgument">
        /// take seconArgument</param>
        /// <returns>
        /// amount
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
