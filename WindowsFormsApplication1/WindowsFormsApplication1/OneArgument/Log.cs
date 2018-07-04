using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Log : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            if (argument <= 0)
            {
                throw new Exception("does't exsist");
            }
            return Math.Log(argument);
        }
    }
}
