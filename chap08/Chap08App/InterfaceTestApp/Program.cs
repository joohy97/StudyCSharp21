using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    /*
    class Ridable
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈것");
        }
    }
    */

    interface ICar //: Ridable
    {
        void Run();

        void Ride();
    }

    interface IPlane //: Ridable
    {
        void Fly();

        void Ride();
    }

    class DroneCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();
        }
    }
}
