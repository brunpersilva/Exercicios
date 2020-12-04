using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void BinaryNum(double n1, double n2);
    class Program
    {
        delegate double Binary(double n1, double n2);

        static void Main(string[] args)
        {

            BinaryNum a = CalcOperation.Sum;
            a += CalcOperation.Mult;
            a(2.4, 35.6);

        }
    }
}
