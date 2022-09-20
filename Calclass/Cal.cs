using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calclass
{
    public class Cal
    {
       public static double  Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public double  Subtraction(double  num1, double  num2)
        {
            double  result = num1 - num2;
            return result;
        }

        public double  Multiplication(double  num1, double  num2)
        {
            double  result = num1 * num2;
            return result;
        }

        public double  Division(double  num1, double  num2)
        {
            double  result = num1 / num2;
            return result;
        }

    }
}
