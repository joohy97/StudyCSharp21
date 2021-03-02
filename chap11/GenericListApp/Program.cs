using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //성능 좋아서 실무에서 자주 쓰이는 컬렉션
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.Reverse();
            Console.WriteLine("역정렬");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.Insert(3, 20);
            Console.WriteLine("값추가");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.RemoveAt(5);
            Console.WriteLine("값삭제");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            List<string> strList = new List<string>() { "일", "이", "삼", "사", "오" };
            Console.WriteLine("문자열");
            foreach (var item in strList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
