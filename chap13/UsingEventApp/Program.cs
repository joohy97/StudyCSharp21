using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message); //메세지 받아서 대신 처리하는 대리자

    class CustomNotifier //이벤트 선언, 사용하는 객체(속성+메서드)
    {
        public event EventHandler SomethingHappened; //속성

        public void DoSomething(int number) //메서드
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) //3의 배수
            {
                SomethingHappened($"{number} : 짝!");
            }
            else
            {
                SomethingHappened($"{number}");
            }
        }
    }

    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); //이벤트를 내가 만든 로직이 있는 메서드랑 연결

            for (int i = 0; i < 100; i++)
            {
                notifier.DoSomething(i);
            }
        }

    }
}
