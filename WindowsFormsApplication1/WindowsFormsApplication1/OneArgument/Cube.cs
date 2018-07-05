namespace WindowsFormsApplication1.OneArgument
{
    public class Cube : ICalculateOneArgument
    {
        /// <summary>
        /// Cube calculation function
        /// </summary>
        /// <param name="argument">
        /// Argument is rased in a cube
        /// </param>
        /// <returns>
        /// Return x^3
        /// </returns>
        public double Calculate(double argument)
        {
            return argument * argument * argument;
        }
    }
}
