namespace WindowsFormsApplication1
{
    public class AmountSquare : ICalculateTwoArguments
    {
        public double Calculate (double firstArgument, double secondArgument)
        {
            return (firstArgument * firstArgument + secondArgument * secondArgument);
        }
    }
}
