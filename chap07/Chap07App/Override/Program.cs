using System;

namespace Override
{
    class ArmorSuite
    {
        public virtual void Initialize() //virtual : 자식클래스에서 재정의할 것 미리 알려줌
        {
            Console.WriteLine("ArmorSuite 초기화");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            //base.Initialize();
            Console.WriteLine("리펄서 레이저 장착");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            //base.Initialize();
            Console.WriteLine("ArmorSuite 개량 WarMachine 초기화");
            Console.WriteLine("Double-Barrel 캐논 장착");
            Console.WriteLine("Micro-Rocket 런처 장착");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

            Console.WriteLine("IronMan 생산");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
        }
    }
}
