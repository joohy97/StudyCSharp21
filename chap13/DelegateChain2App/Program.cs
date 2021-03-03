using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereIsAFire(string location);

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? 불났어요, 주소는 {location}이에요!");
        }

        static void ShoutOut(string location)
        {
            Console.WriteLine($"불이야!! {location}에 불났어요!");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나가야해요!");
        }

        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(ShoutOut);
            fire += Call119;
            fire += Escape;

            fire("부경대학교 대연캠퍼스 C23");
        }
    }
}
