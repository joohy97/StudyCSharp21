using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 3;
            int val = 0, rem = 0;
            int rval = 0, rrem = 0;
            Divide(a, b, out val, out rem);
            DivideRef(a, b, ref rval, ref rrem);

            Console.WriteLine($"{a} / {b} = {val} ... {rem}");
            Console.WriteLine($"{a} / {b} = {rval} ... {rrem}");

            bool isSucceed = int.TryParse("1000.74", out int result);
            Console.WriteLine($"변환 : {isSucceed} {result}");

        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void DivideRef(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
