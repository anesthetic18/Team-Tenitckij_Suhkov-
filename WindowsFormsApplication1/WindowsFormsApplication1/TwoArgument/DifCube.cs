namespace WindowsFormsApplication1.TwoArgument
{
    public class DifCube : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument * firstArgument) - (secondArgument * secondArgument * secondArgument);
        }
    }
}
