namespace WindowsFormsApplication1.TwoArgument
{
    public class DoubleDivision : ICalculateTwoArguments
    {
        /// <summary>
        /// function of double division
        /// </summary>
        /// <param name="firstArgument">
        /// first argument - delimoe
        /// </param>
        /// <param name="secondArgument">
        /// second argument - delitel'
        /// </param>
        /// <returns>
        /// 2* (x/y)
        /// </returns>
        public double Calculate (double firstArgument, double secondArgument)
        {
            return 2 * (firstArgument / secondArgument);
        }
    }
}
