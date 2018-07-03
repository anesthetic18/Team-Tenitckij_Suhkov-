namespace WindowsFormsApplication1
{
    public class ClassAmount:ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
