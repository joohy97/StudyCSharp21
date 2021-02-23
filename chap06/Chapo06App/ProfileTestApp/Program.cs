using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("성명건", "010-6683-7732");

            PrintProfile(null, "010-1111-2222");
        }
    
        public static void PrintProfile(string name, string phone)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return;
            }
            Console.WriteLine($"이름 : {name}, 번호 : {phone}");
        }
    
    }
}
