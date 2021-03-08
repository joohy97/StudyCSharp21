# StudyCSharp21

2021.02.21. ~ 2021.03.08.
교재 : 시작하세요! C# 8.0 프로그래밍(위키북스)
강의 교안 : 이것이 C#이다 (한빛미디어)
PKNU C# 학습 리포지토리


## Basic C#

기본문법 학습

---------------------------------------------

### 1장 닷넷 프레임워크


### 2장 개발 환경 준비
 : 비주얼 스튜디오 이용


### 3장 C# 기초
 - 자료형(변수)
 - 형변환
 - 배열
 - 제어문 : 선택문, 반복문, 점프문


### 4장 객체지향 문법
 - 클래스 : 필드, 메서드, 생성자, 종료자
 - 캡슐화
 - 상속
 - 다형성 : 오버라이드, 오버로드
 - 클래스 확장 : 델리게이트, 인터페이스

---------------------------------------------
## 예제 : 주소록 만들기

[소스보기](https://github.com/joohy97/StudyCSharp21/tree/main/chap99/AddressBookApp)

수정, 삭제, 검색 시 IndexOf를 이용하여 특정 단어가 포함된 이름을 찾을 수 있게 했습니다
```csharp
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
```

