using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    public class Sin : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
