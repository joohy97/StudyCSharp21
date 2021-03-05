using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }

        public SideTask(int count)
        {
            Count = count;
        }

        public void Countdown()
        {
            while (Count > 0)
            {
                Console.WriteLine($"{Count} 남음");
                Count--;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Count : {Count}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.Countdown);
            th.IsBackground = false; //이 스레드가 종료되기 전까지는 프로세스가 끝나지 않음
            //ture 일때 : 백그라운드 스레드가 돌고 있는 상태에도 메인 스레드가 끝나면 모두 종료

            Console.WriteLine("스레드 시작");
            th.Start();

            Thread.Sleep(1000);

            th.Join();

        }
    }
}
