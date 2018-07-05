namespace WindowsFormsApplication1.TwoArgument
{
    public class DifDivision : ICalculateTwoArguments
    {
        /// <summary>
        /// function of difference of division
        /// </summary>
        /// <param name="firstArgument">
        /// first argument / second argument</param>
        /// <param name="secondArgument">
        /// second argument / first argument</param>
        /// <returns>
        /// difference of divicsion
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return  (firstArgument / secondArgument) - (secondArgument / firstArgument);
        }
    }
}
