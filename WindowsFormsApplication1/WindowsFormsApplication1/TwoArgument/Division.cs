namespace WindowsFormsApplication1.TwoArgument
{
   public class Division : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
