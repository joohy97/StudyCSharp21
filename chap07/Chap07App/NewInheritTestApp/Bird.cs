using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine($"{Name}이 납니다(파닥파닥)");
        }
    }
}
