namespace WindowsFormsApplication1.TwoArgument
{
    public class AmountSquare : ICalculateTwoArguments
    {
        public double Calculate (double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument + secondArgument * secondArgument);
        }
    }
}
