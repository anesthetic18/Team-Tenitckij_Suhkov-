namespace WindowsFormsApplication1.TwoArgument
{
    public class DoubleMultiply : ICalculateTwoArguments
    {
        /// <summary>
        /// funciton of double multiply
        /// </summary>
        /// <param name="firstArgument">
        /// first argument
        /// </param>
        /// <param name="secondArgument">
        /// second argument
        /// </param>
        /// <returns>
        /// 2*x*y
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return 2 * (firstArgument * secondArgument);
        }
    }
}
