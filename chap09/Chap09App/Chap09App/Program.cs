using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{
    class MyClass
    {
        private int iValue; //0~120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        public int IValue 
        {
            get 
            {
                return this.iValue;
            }
            set 
            {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;

            } 
        }

        public MyClass(int value)
        {
            //this.SetValue(value);
            
        }

        /*
        public void SetValue(int value)
        {
            if (value < 0)
            {
                this.value = 0;
            }
            else if (value > 120)
            {
                this.value = 120;
            }
            else
            {
                this.value = value;
            }
            
        }

        public int GetValue()
        {
            return this.value;
        }
        */

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.IValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass(1200);
            myclass.PrintValue();

            //myclass.SetValue(2345);
            myclass.IValue = 1200;
            myclass.PrintValue();
            //Console.WriteLine($"현재 온도는 {myclass.GetValue()}℃입니다");
            Console.WriteLine($"현재 온도는 {myclass.IValue}℃입니다");
        }
    }
}
