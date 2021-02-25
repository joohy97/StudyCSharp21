using System;

namespace PropertyTestApp
{
    class BirthdayInfo //생일정보 클래스
    {
        public string name; //이름
        public DateTime birthday; //생일

        #region Property
        public string Name
        {
            get { return this.name; }
            set { this.name = value; } //매개변수가 없어서 어떤 값을 넣어야 하는 지 모를때 value 사용
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        #endregion

        #region Get, Set Method
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
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 일반 메서드 사용 ***");
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}");

            Console.WriteLine("*** 프로퍼티 사용 ***");
            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순";
            info2.Birthday = new DateTime(1992, 3, 16);

            Console.WriteLine($"이름 : {info2.Name}");
            Console.WriteLine($"생일 : {info2.Birthday}");
        }
    }
}
