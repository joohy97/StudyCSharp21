﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;

            Console.WriteLine($"Before Swap {x}, {y}");

            Program.Swap(ref x, ref y); //ref : 변수의 주소
            /*Program.Swap(x, y);*/

            Console.WriteLine($"After Swap {x}, {y}");
        }

        private static void Swap(ref int p1, ref int p2)
        {
            int temp = 0; //temp, p1, p2
            temp = p1; //p1, p1, p2
            p1 = p2; //p1, p2, p2
            p2 = temp; //p1, p2, p1
        }
        /*
        private static void Swap(int p1, int p2)
        {
            int temp = 0; //temp, p1, p2
            temp = p1; //p1, p1, p2
            p1 = p2; //p1, p2, p2
            p2 = temp; //p1, p2, p1
        }
        */
    }
}
