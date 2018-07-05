namespace WindowsFormsApplication1.TwoArgument
{
    public class Subtraction : ICalculateTwoArguments
    {
        /// <summary>
        /// function of subtraction
        /// </summary>
        /// <param name="firstArgument">
        /// first argument - ymen'shaemoe
        /// </param>
        /// <param name="secondArgument">
        /// second argument - ymen'shitel'
        /// </param>
        /// <returns>
        /// x - y
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
