namespace WindowsFormsApplication1.TwoArgument
{
    public class DoubleDifSquare : ICalculateTwoArguments
    {
        /// <summary>
        /// function of double difference of square
        /// </summary>
        /// <param name="firstArgument">
        /// first argunet ^ 2
        /// </param>
        /// <param name="secondArgument">
        /// second argument ^ 2
        /// </param>
        /// <returns>
        /// (x*x) - (y*y)
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument) - (secondArgument * secondArgument);
        }
    }
}
