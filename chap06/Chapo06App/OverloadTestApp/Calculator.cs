using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기");

            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"INT : 3 + 4 = {x}");

            int z = Calculator.Plus(7, 8, 9);
            Console.WriteLine($"INT : 7 + 8 + 9 = {z}");

            float y = Calculator.Plus(3.14f, 5.6f); //float
            Console.WriteLine($"FLOAT : 3.14 + 5.6 = {y}");

            Console.WriteLine($"DOUBLE : 3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");//double

            Console.WriteLine($"CHAR : 3.14 + 5 = {Calculator.Plus(3.14, "5")}");

            //오버로딩의 문제점 -> 가변길이 매개변수 params 키워드와 배열 이용
            
            int total = 0;
            total = sum(1, 2);
            Console.WriteLine($"합계는 {total}");

            total = sum(1, 2, 3);
            Console.WriteLine($"합계는 {total}");

            total = sum(1, 2, 3, 4);
            Console.WriteLine($"합계는 {total}");

            total = sum(1, 2, 3, 4, 5);
            Console.WriteLine($"합계는 {total}");

            Console.WriteLine($"10까지의 합은 : {sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine($"10까지의 합은 : {sum(arrs)}");
        }

        private static int sum(params int[] args)
        {
            int result = 0;
            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }

        /*
        private static int sum(int v1, int v2, int v3, int v4, int v5)
        {
            int result = v1 + v2 + v3 + v4 + v5;
            return result;
        }

        private static int sum(int v1, int v2, int v3, int v4)
        {
            int result = v1 + v2 + v3 + v4;
            return result;
        }

        private static int sum(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static int sum(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }
        */

        private static object Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        private static object Plus(double v1, double v2) //바로 출력하게 돼서 어떤 자료형으로 반환하는 지 몰라서 object로 생성됨(박싱)
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

    }
}
