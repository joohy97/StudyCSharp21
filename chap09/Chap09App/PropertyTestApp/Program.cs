using System;

namespace PropertyTestApp
{
    class BirthdayInfo //생일정보 클래스
    {
        public string name;
        public DateTime birthday;
        public string GetName()
        {
            return this.name;
        }    

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
