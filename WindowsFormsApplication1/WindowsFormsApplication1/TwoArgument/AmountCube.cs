namespace WindowsFormsApplication1.TwoArgument
{
    public class AmountCube : ICalculateTwoArguments
    {
        /// <summary>
        /// function of amount of cube 
        /// </summary>
        /// <param name="firstArgument">
        /// first argument</param>
        /// <param name="secondArgument">
        /// second argument</param>
        /// <returns>
        /// amount of cube
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument * firstArgument) + (secondArgument * secondArgument * secondArgument);
        }
    }
}
