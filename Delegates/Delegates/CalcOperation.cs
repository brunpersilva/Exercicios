using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     public class CalcOperation
    {
        public static void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mult(double a, double b)
        {
            Console.WriteLine(a*b);
        }
    }
}
