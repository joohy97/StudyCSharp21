using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    class AddressManager
    {
        
        public List<AddressInfo> listAddress;

        public void PrintMenu()
        {
            //메인 메뉴
            Console.WriteLine("주소록입니다");
            Console.WriteLine("---------------------------------------- ♥");
            Console.WriteLine(" * 1. 주소 입력\n * 2. 주소 검색\n * 3. 주소 수정\n * 4. 주소 삭제\n * 5. 주소 전체 출력\n * 6. 프로그램 종료");
            Console.WriteLine("---------------------------------------- ♡");
            Console.Write("원하는 메뉴의 번호를 입력하세요 >>> ");
        }
        public int SelectMenu()
        {
            //메뉴 번호 입력받기
            int.TryParse(Console.ReadLine(), out int menuNum);

            //메뉴 번호 예외 처리
            if (menuNum < 1 || menuNum > 6) menuNum = 0;
            return menuNum;
        }
        public void InputAddress()
        {
            Console.Clear();
            Console.WriteLine("주소 입력을 선택하셨습니다.");
            Console.WriteLine("---------------------------------------- ♥");
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();
            Console.WriteLine("---------------------------------------- ♡");

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("이름 또는 전화번호가 비어있습니다.");
            }
            else
            {
                listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
                Console.WriteLine("주소가 입력되었습니다.");
            }
            Console.WriteLine($"메인 메뉴로 돌아가려면 아무 키나 누르세요.");
            Console.ReadKey();

        }
        public void SearchAddress()
        {
            Console.WriteLine("주소 검색을 선택하셨습니다.");
            Console.WriteLine("---------------------------------------- ♥");
            Console.Write("검색할 이름 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; //찾는 이름이 있는 지

            foreach (var item in listAddress)
            {
                if (item.Name.IndexOf(name) >= 0)
                {
                    isFind = true;
                    Console.Clear();
                    Console.WriteLine($"이름에 {name}이 포함된 주소를 검색합니다.");
                    Console.WriteLine("---------------------------------------- ♥");
                    Console.WriteLine($"[{idx + 1}]");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("---------------------------------------- ♡");
                    break; //foreach 에서 탈출
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("---------------------------------------- ♡");
                Console.WriteLine("검색 결과가 없습니다.");
            }
            Console.WriteLine($"메인 메뉴로 돌아가려면 아무 키나 누르세요.");
            Console.ReadKey();
        }
        public void UpdateAddress()
        {
            Console.WriteLine("주소 수정을 선택하셨습니다.");
            Console.WriteLine("---------------------------------------- ♥");
            Console.Write("수정할 이름 : ");
            string name = Console.ReadLine();
            bool isFind = false;
            int idx = 0;
            foreach (var item in listAddress)
            {
                if (item.Name.IndexOf(name) >= 0)
                {
                    isFind = true;
                    Console.Clear();
                    Console.WriteLine($"이름에 {name}이 포함된 주소를 검색합니다.");
                    Console.WriteLine("---------------------------------------- ♥");
                    Console.WriteLine($"[{idx + 1}]");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("---------------------------------------- ♡");
                    Console.Write("새로운 이름 : ");
                    string uName = Console.ReadLine();
                    Console.Write("새로운 번호 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("새로운 주소 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhone))
                    {
                        Console.WriteLine("이름 또는 전화번호가 비어있습니다.");
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;
                        Console.WriteLine("주소가 수정되었습니다.");
                    }


                    break; //foreach 에서 탈출
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("---------------------------------------- ♡");
                Console.WriteLine("검색 결과가 없습니다.");
            }
            Console.WriteLine($"메인 메뉴로 돌아가려면 아무 키나 누르세요.");
            Console.ReadKey();
        }
        public void DeleteAddress()
        {
            Console.WriteLine("주소 삭제를 선택하셨습니다.");
            Console.WriteLine("---------------------------------------- ♥");
            Console.Write("삭제할 이름 : ");
            string name = Console.ReadLine();
            bool isFind = false;
            int idx = 0;
            foreach (var item in listAddress)
            {
                if (item.Name.IndexOf(name) >= 0)
                {
                    isFind = true;
                    Console.Clear();
                    Console.WriteLine($"이름에 {name}이 포함된 주소를 검색합니다.");
                    Console.WriteLine("---------------------------------------- ♥");
                    Console.WriteLine($"[{idx + 1}]");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("---------------------------------------- ♡");
                    Console.Write("이 주소를 삭제하시겠습니까? [y/n]");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        listAddress.RemoveAt(idx);
                        Console.WriteLine("주소를 삭제했습니다.");
                    }
                    break; //foreach 에서 탈출
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("---------------------------------------- ♡");
                Console.WriteLine("검색 결과가 없습니다.");

            }
            Console.WriteLine($"메인 메뉴로 돌아가려면 아무 키나 누르세요.");
            Console.ReadKey();
        }
        public void PrintAll()
        {
            Console.WriteLine("주소 전체 출력을 선택하셨습니다.");
            Console.WriteLine("---------------------------------------- ♥");
            int idx = 0;
            if (listAddress.Count == 0)
            {
                Console.WriteLine("주소록이 없습니다.");
            }
            else
            {
                foreach (var item in listAddress)
                {
                    Console.WriteLine($"[{idx + 1}]");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("");
                    idx++;
                }
                Console.WriteLine("---------------------------------------- ♡");
            }
            Console.WriteLine($"메인 메뉴로 돌아가려면 아무 키나 누르세요.");
            Console.ReadKey();
        }
    }
}

