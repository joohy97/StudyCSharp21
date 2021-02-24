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

            PrintProfile(phone: "010-9999-9999", name: "홍길동");

            PrintProfile(name:"홍길순",phone:"010-8888-8888");

            PrintProfile("최백호");
            PrintProfile("최백호", "010-4444-5555");
        }

        public static void PrintProfile(string name, string phone = "010-0000-0000") //디폴트 파라미터, 뒤에서부터 넣어야함(매개변수 갯수 판단 문제)!
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("$$ 오류 : 이름을 정확히 입력하세요.");
                return;
            }
            Console.WriteLine($"이름 : {name}, 번호 : {phone}");
        }

    }
}
