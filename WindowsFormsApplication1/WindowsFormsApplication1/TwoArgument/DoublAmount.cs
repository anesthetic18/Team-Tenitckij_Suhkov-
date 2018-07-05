namespace WindowsFormsApplication1.TwoArgument
{
    public class DoublAmount : ICalculateTwoArguments
    {
        /// <summary>
        /// function of double amount
        /// </summary>
        /// <param name="firstArgument">
        /// first argument </param>
        /// <param name="secondArgument">
        /// second argument</param>
        /// <returns>
        /// 2 * amount
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return 2*(firstArgument + secondArgument);
        }
    }
}
