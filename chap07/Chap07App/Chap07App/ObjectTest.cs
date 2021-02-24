using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 테스트");

            Cat cat1 = new Cat(); //고양이 객체의 실체(instance) 생성
            
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
        }
    }

    class Cat
    {
        public Cat() { }

        public Cat(string _name, string _color)
        {
            Name = _name;
            Color = _color;
        }

        public Cat(string _name, string _color, string _gender)
        {
            Name = _name;
            Color = _color;
            Gender = _gender;
        }

        /*
        public Cat()
        {
            Name = "길동이";
            Color = "모르는색";
        }
        */



        public string Name;
        public string Color;
        public string Gender;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
}
