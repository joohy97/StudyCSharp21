using System;
using System.Collections.Generic;
using System.Text;

namespace NewInheritTestApp
{
    class Animal
    {
        public string Name { get; set; } //프로퍼티
        public int Age { get; set; }

        public void Breath()
        {
            Console.WriteLine($"{Name}이 숨을 쉽니다.");
        }
    }


}
