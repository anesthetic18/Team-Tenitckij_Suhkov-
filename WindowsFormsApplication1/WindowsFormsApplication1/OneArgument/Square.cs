namespace WindowsFormsApplication1
{
    public class Square : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}
