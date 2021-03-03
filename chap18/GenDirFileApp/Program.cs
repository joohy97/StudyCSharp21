using System;
using System.IO;

namespace GenDirFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = "D:\\GitRepository\\StudyCSharp21\\SampleDir";
            string strTargetDir = "SubFolder";
            string strTargetFile = "readme.txt";

            //폴더 만들기
            string targetPath = $"{strDir}\\{strTargetDir}";
            if (Directory.Exists(targetPath))
            {
                Console.WriteLine("이미 폴더가 존재합니다.");
            }
            else
            {
                Directory.CreateDirectory(targetPath);
                Console.WriteLine("경로에 폴더를 만들었습니다.");
            }

            //파일 만들기
            targetPath += $"\\{strTargetFile}";
            if (File.Exists(targetPath))
            {
                Console.WriteLine("이미 파일이 존재합니다.");
            }
            else
            {
                File.Create(targetPath).Close();
                Console.WriteLine("경로에 파일을 만들었습니다.");
            }

        }
    }
}
