using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\GitRepository\StudyCSharp21\SampleDir\SubFolder\a.dat";

            //파일 쓰기
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(new FileStream(filePath, FileMode.Append));
                sw.WriteLine($"{ int.MaxValue}");
                sw.WriteLine($"Hello, World!");
                sw.WriteLine($"uint.MaxValue = {uint.MaxValue}");
                sw.WriteLine($"안녕하세요");
                sw.WriteLine($"double.MaxValue = {double.MaxValue}");

                Console.WriteLine("파일 생성 완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"파일쓰기 예외 발생({ex.Message}");
                throw;
            }
            finally
            {
                sw.Close();
            }


            //파일 읽기
            StreamReader sr = null;
            sr = new StreamReader(new FileStream(filePath, FileMode.Open));
            Console.WriteLine($"File Size : {sr.BaseStream.Length} byte");

            while (sr.EndOfStream == false) //파일의 마지막까지
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
