using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{

    class Test
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var array = new int[5];
            array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;
            */

            int[] array = { 80, 74, 81, 90, 34 };

            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"BaseYpe of array : {array.GetType().BaseType}");
            


            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            /*
            Console.WriteLine();
            var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }
            */

            Array.Sort(array);
            Console.WriteLine();
            Console.WriteLine("오름차순 정렬 후 배열 출력");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Array.Reverse(array);
            Console.WriteLine();
            Console.WriteLine("내림차순 정렬 후 배열 출력");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine();
            int idx = Array.IndexOf(array, 34);
            Console.WriteLine("34의 위치 : " + idx);

            Console.WriteLine();
            idx = Array.IndexOf(array, 100);
            Console.WriteLine("100의 위치 : " + idx);

            Array.Clear(array, 3, 2);
            Console.WriteLine();
            Console.WriteLine("배열 요소 삭제");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
        }
    }
}
