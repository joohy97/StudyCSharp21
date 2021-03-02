using System;

namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y);

    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            Plus(10, 5);
            Minus(10, 5);
            Multiple(10, 5);
            Divide(10, 5);
            */

            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5);
        }
    }
}
