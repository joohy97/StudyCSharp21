using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            //while
            while (a > 0)
            {
                Console.WriteLine($"숫자 감소 {a}");
                //a--;
                a -= 2;
            }
            Console.WriteLine("종료합니다");

            //do while
            do
            {
                Console.WriteLine($"숫자 증가{a}");
                a++;
            } while (a < 10);
            Console.WriteLine("종료합니다");

            //for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i 증가값은 {i}");
            }
            Console.WriteLine("종료합니다");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"i 감소값은 {i}");
            }
            Console.WriteLine("종료합니다");

            //구구단
            Console.WriteLine("구구단 시작");
            for (int i = 2; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine($"\n{i}단 끝!");
            }



        }
            
    }
}
