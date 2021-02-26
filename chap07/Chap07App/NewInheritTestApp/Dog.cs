using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} : 멍멍멍!");
        }

        public void HowOld()
        {
            Console.WriteLine($"{Name}의 나이는 {Age}");
        }
    }
}
