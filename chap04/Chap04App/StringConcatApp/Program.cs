﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<숫자 더하기>>>");
            var p2 = 456;
            Console.WriteLine(123 + p2); //579
            Console.WriteLine("123" + p2); //?
            Console.WriteLine($"123{p2}"); //제일 많이 쓰이는 형태
            Console.WriteLine("123" + "456"); //??

            // 관계 연산자
            Console.WriteLine("<<<관계연산자>>>");
            int a = 30, b = 30;
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // 논리 연산자
            Console.WriteLine("<<<논리연산자>>>");
            Console.WriteLine(10 > 9 && a > 0);
            Console.WriteLine(a > b || b > 0);
            Console.WriteLine(!(a < b));

            // 조건 연산자 : 단항 if문 대체 가능
            Console.WriteLine("<<<조건연산자>>>");
            int c = 30;
            string result;

            if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";
            result = c == 30 ? "삼십" : "삼십아님";
            Console.WriteLine(result);

            // 병합 연산자
            Console.WriteLine("<<<NULL 병합연산자>>>");
            int? d = null;
            Console.WriteLine($"{d ?? 0}");
        }
    }
}
