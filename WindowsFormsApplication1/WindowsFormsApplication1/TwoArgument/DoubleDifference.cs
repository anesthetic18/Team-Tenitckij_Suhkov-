namespace WindowsFormsApplication1.TwoArgument
{
    public  class DoubleDifference : ICalculateTwoArguments
    {
        /// <summary>
        /// function of double difference
        /// </summary>
        /// <param name="firstArgument">
        /// first argument - ymen'shaemoe
        /// </param>
        /// <param name="secondArgument">
        /// second argument - ymen'shitel'
        /// </param>
        /// <returns>
        /// 2 * (x-y)
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return 2 * (firstArgument - secondArgument);
        }
    }
}
