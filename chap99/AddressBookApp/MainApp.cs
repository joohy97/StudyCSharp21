using System;
using System.Collections.Generic;

namespace AddressBookApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AddressManager manager = new AddressManager();
            manager.listAddress = new List<AddressInfo>();
            
            while (true)
            {
                Console.Clear();
                manager.PrintMenu(); //메인메뉴 불러오기

                int menuNum = manager.SelectMenu(); //메뉴 번호 입력받기

                switch (menuNum)
                {
                    case 1: //주소 입력
                        manager.InputAddress();
                        break;

                    case 2: //주소 검색
                        Console.Clear();
                        manager.SearchAddress();
                        break;

                    case 3: //주소 수정
                        Console.Clear();
                        manager.UpdateAddress();
                        break;

                    case 4: //주소 삭제
                        Console.Clear();
                        manager.DeleteAddress();
                        break;

                    case 5: //주소 전체 출력
                        Console.Clear();
                        manager.PrintAll();
                        break;
                    case 6: //프로그램 종료
                        Environment.Exit(0);
                        break;
                    default: // 0 처리
                        break;
                }

            }

        }

        
    }
}
