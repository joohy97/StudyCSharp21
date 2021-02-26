using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이가 숨을 쉰다.");
        }

        public void Move()
        {
            Console.WriteLine($"{this.Name}가 네발로 이동한다.");
        }
    }

    class dog : Mammal
    {
        public void Move()
        {
            Console.WriteLine($"{this.Name}가 네발로 달린다.");
        }
    }

    class Human : Mammal
    {
        public void Move()
        {
            Console.WriteLine($"{this.Name}가 두발로 움직인다.");
        }
    }

    class Whale : Mammal
    {
        public void Move()
        {
            Console.WriteLine($"{this.Name}가 헤엄쳐서 움직인다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dog ppoppi = new dog();
            ppoppi.Name = "뽀삐";
            ppoppi.Move();

            Human mansigi = new Human();
            mansigi.Name = "만식이";
            mansigi.Move();

            Whale whale = new Whale();
            whale.Name = "고래고래";
            whale.Move();
        }
    }
}
