using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App
{
    delegate int MyDelegate(int a, int b); //대리자, 대신 호출

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            /*
            var result = calc.Plus(3, 4);
            Console.WriteLine($"result : {result}");
            */

            MyDelegate Callback;
            Callback = new MyDelegate(calc.Plus); //메서드인데 괄호 없음
            Console.WriteLine($"result : {Callback(3,4)}");
        }
    }
}
