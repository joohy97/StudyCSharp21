using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 테스트");

            /*
            Cat cat1 = new Cat(); //고양이 객체의 실체(instance) 생성
            Cat cat1 = new Cat(Name: "야옹이", Color: "흰색")
            //cat1.Name = "꼬미";
            //cat1.Color = "태비";
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검은색";
            nero.Meow();
            */

            Cat yomi = new Cat("요미", "흰색", "암컷");
            yomi.Meow();

        }
    }

    class Cat
    {
        public Cat() { }

        public Cat(string Name)
        {
            this.Name = Name;
        }

        public Cat(string Name, string Color) : this(Name) //위의 생성자 Cat이 호출되어 Name이 초기화됨
        {
            //this.Name = Name;
            this.Color = Color;
        }

        public Cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            //this.Name = Name;
            //this.Color = Color;
            this.Gender = Gender;
        }

        public string Name;
        public string Color;
        public string Gender;

        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색:{this.Color}/ 성별:{Gender}) : 야옹");
        }
    }
}
