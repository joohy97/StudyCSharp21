using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍()");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            _포유류 = new 강아지(); //형변환 부모(big)<-자식(small). 자식을 부모에 담음. 포유류(부모)였던 _포유류가 강아지(자식)으로 형변환
            _포유류.키우다();
            강아지 쭈쭈;

            if (_포유류 is 강아지) //true
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }

            //강아지 뽀삐 = null;
            강아지 뽀삐 = new 강아지();
            if (뽀삐 is 포유류) //false
            {
                Console.WriteLine("실행");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }


            /* 실행 오류
            //강아지 뽀삐 = new 포유류(); //컴파일 오류 자식(small)<-부모(big)
            강아지 뽀삐 = (강아지) new 포유류(); //형변환 자식(small)<-부모(big) 가능
            뽀삐.키우다();
            //뽀삐.멍멍(); 
            //형변환으로 부모 클래스로 만들어도 자식 클래스의 메소드 호출 가능하지만 실행 오류
            //본래 부모 클래스에 멍멍이라는 메소드가 없기 때문

            고양이 로미 = (고양이) new 포유류();
            //로미.야옹();
            */


        }
    }
}
