using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        private int temp = 5;
        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 범위를 벗어났으므로 45℃로 온도를 설정합니다.");
                this.temp = 59;
                return;            
            } 
            else
            {
                this.temp = temp;
            }
            

        }

        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 작동시킵니다.");
        }

        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 중지시킵니다.");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재 온도는 {currTemp}℃ 입니다");

            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);

            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler();
            }


        }
    }
}
