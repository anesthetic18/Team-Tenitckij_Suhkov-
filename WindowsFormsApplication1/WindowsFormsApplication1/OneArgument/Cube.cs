namespace WindowsFormsApplication1.OneArgument
{
    public class Cube : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return argument * argument * argument;
        }
    }
}
