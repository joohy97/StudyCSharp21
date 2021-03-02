using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 5; i++) //예외 : 컴파일상 오류는 없지만 실행오류 발생
                {
                    Console.WriteLine($"{i}번째 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine("계속 실행");

            int x = 108, y = 0;
            int result = 0;

            try
            {
                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            try
            {
                string strVal = "HelloWorld";
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"자른 문자 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있습니다. {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화하세요 {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"기타 예외 발생 {ex.Message}");
            }
        }
    }
}
