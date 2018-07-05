namespace WindowsFormsApplication1.TwoArgument
{
    public class DifCube : ICalculateTwoArguments
    {
        /// <summary>
        /// function of difference of cube
        /// </summary>
        /// <param name="firstArgument">
        /// first argument</param>
        /// <param name="secondArgument">
        /// second argument</param>
        /// <returns>
        /// difference of cube
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument * firstArgument) - (secondArgument * secondArgument * secondArgument);
        }
    }
}
