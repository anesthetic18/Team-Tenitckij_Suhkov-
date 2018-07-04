using System;

namespace WindowsFormsApplication1.OneArgument
{
        public class Arcsin : ICalculateOneArgument
        {
            public double Calculate(double argument)
            {
                if (argument < -1 || argument > 1)
                {
                    throw new Exception("does't exsist");
                }
            return Math.Asin(argument);
            }
        }
    
}
