namespace WindowsFormsApplication1.TwoArgument
{
    public class DoubleDivision : ICalculateTwoArguments
    {
        public double Calculate (double firstArgument, double secondArgument)
        {
            return 2 * (firstArgument / secondArgument);
        }
    }
}
