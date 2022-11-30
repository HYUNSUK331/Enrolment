using Enrolment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment.View.InterestedClass
{
    namespace Enrolment.View
    {
        public class MainTwo : Controller1
        {
            private static MainTwo numberInstance = null;

            public static MainTwo Instance                                   //싱글톤 패턴으로 선언
            {
                get
                {
                    if (numberInstance == null)
                        numberInstance = new MainTwo();
                    return numberInstance;
                }
            }

            // 2. 관심 과목
            public void numberTwo()
            {
                MainPage mainPage = new MainPage();
                while (true)
                {
                    Title.title();
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    1. 관심 강의 추가");
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    2. 관심 강의 삭제");
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    3. 관심 강의 조회");
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    4. 전체 강의 목록");
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    5. 강의 검색");
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    6. 처음 메뉴 돌아가기");
                    Console.WriteLine("");
                    Console.WriteLine("                             >>    7. 종     료 ");
                    Console.WriteLine("");
                    Console.Write("                            원하는 메뉴를 선택해 주세요 :");
                     
                    String str =Console.ReadLine();

                    Console.Clear();
                    switch (str)
                    {
                        case "1":
                            numberTwoInOne();
                            break;
                        case "2":
                            numberTwoInTwo();
                            break;
                        case "3":
                            numberTwoInThree();
                            break;
                        case "4":
                            numberTwoInFour();
                            break;
                        case "5":
                            numberTwoInFive();
                            break;
                        case "6":
                            mainPage.mainPage();
                            break;
                        case "7":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("                            다시 입력해 주세요(Enter 누르세요)");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }

                }
            }


            // 2-1 관심과목 추가
            public void numberTwoInOne()
            {
                Console.Clear();

                Title.title();
                Console.WriteLine("");
                Console.WriteLine("               >>    1. 개설 학과 전공으로 검색하여 관심 과목 추가");
                Console.WriteLine("");
                Console.WriteLine("               >>    2. 학수 번호로 검색하여 관심 과목 추가 ");
                Console.WriteLine("");
                Console.WriteLine("               >>    3. 교과목 명으로 검색하여 관심 과목 추가");
                Console.WriteLine("");
                Console.WriteLine("               >>    4. 강의 대상 학년으로 검색하여 관심 과목 추가");
                Console.WriteLine("");
                Console.WriteLine("               >>    5. 교수명으로 검색하여 관심 과목 추가");
                Console.WriteLine("");
                Console.WriteLine("                            >> 6. 뒤로 가기 <<");
                Console.WriteLine("");
                Console.WriteLine("                              >> 7. 종료 <<");
                Console.WriteLine("");
                Console.WriteLine("                       원하는 메뉴를 선택해 주세요 :");

                String str = Console.ReadLine();
                Console.Clear();

                switch (str)
                {
                    case "1":
                        numberTwoInOneInOne();
                        break;
                    case "2":
                        numberTwoInOneInTwo();
                        break;
                    case "3":
                        numberTwoInOneInThree();
                        break;
                    case "4":
                        numberTwoInOneInFour();
                        break;
                    case "5":
                        numberTwoInOneInFive();
                        break;
                    case "6":
                        numberTwo();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                }
            }

            // 2-1-1 개설 학과 전공으로 검색하여 관심 수강 신청
            public void numberTwoInOneInOne()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("개설 학과 전공 이름으로 검색: ");
                List<MainData> searchedList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allDataList2.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allDataList2[i].major.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchedList.Add(allDataList2[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchedList);                //검색한 데이터 보여주기
                    }

                    bool isDone = true;           // 수강 신청 추가를 실행하기 위한 bool
                    if (isResult == true)
                    {
                        isDone = false;
                    }
                    InterestList(isDone, searchedList);
                }

            }
            // 2-1-2 학수 번호로 검색하여 관심 수강 신청
            public void numberTwoInOneInTwo()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("학수 번호로 검색: ");
                List<MainData> searchedList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allDataList2.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allDataList2[i].number.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchedList.Add(allDataList2[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchedList);                //검색한 데이터 보여주기
                    }

                    bool isDone = true;           // 수강 신청 추가를 실행하기 위한 bool
                    if (isResult == true)
                    {
                        isDone = false;
                    }
                    InterestList(isDone, searchedList);
                }
            }
            // 2-1-3 교과목 명으로 검색하여 관심 수강 신청
            public void numberTwoInOneInThree()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("학수 번호로 검색: ");
                List<MainData> searchedList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allDataList2.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allDataList2[i].name.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchedList.Add(allDataList2[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchedList);                //검색한 데이터 보여주기
                    }

                    bool isDone = true;           // 수강 신청 추가를 실행하기 위한 bool
                    if (isResult == true)
                    {
                        isDone = false;
                    }
                    InterestList(isDone, searchedList);
                }
            }
            // 2-1-4 강의 대상 학년으로 검색하여 관심 수강 신청
            public void numberTwoInOneInFour()
            {
                    bool isResult = false;
                    Title.title();
                    Console.WriteLine("학수 번호로 검색: ");
                    List<MainData> searchedList = new List<MainData>();

                    while (isResult == false)
                    {
                        string str = Console.ReadLine();

                        if (str == "\0")
                        {
                            break;
                        }

                        for (int i = 1; i < allDataList2.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                        {
                            if (allDataList2[i].grade.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                            {
                                searchedList.Add(allDataList2[i]);
                                isResult = true;
                            }
                        }

                        if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                        {
                            Console.WriteLine();
                            Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                        {
                            Console.WriteLine();
                            InPutData(searchedList);                //검색한 데이터 보여주기
                        }

                        bool isDone = true;           // 수강 신청 추가를 실행하기 위한 bool
                        if (isResult == true)
                        {
                            isDone = false;
                        }
                        InterestList(isDone, searchedList);
                    }
               
            }
            // 2-1-5 교수명으로 검색하여 관심 수강 신청
            public void numberTwoInOneInFive()
            {
                    bool isResult = false;
                    Title.title();
                    Console.WriteLine("학수 번호로 검색: ");
                    List<MainData> searchedList = new List<MainData>();

                    while (isResult == false)
                    {
                        string str = Console.ReadLine();

                        if (str == "\0")
                        {
                            break;
                        }

                        for (int i = 1; i < allDataList2.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                        {
                            if (allDataList2[i].professor.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                            {
                                searchedList.Add(allDataList2[i]);
                                isResult = true;
                            }
                        }

                        if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                        {
                            Console.WriteLine();
                            Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                        {
                            Console.WriteLine();
                            InPutData(searchedList);                //검색한 데이터 보여주기
                        }

                        bool isDone = true;           // 수강 신청 추가를 실행하기 위한 bool
                        if (isResult == true)
                        {
                            isDone = false;
                        }
                        InterestList(isDone, searchedList);
                    }
               
            }






            // 2-2 강의 삭제
            public void numberTwoInTwo()
            {
                while (true)
                {
                    ViewList(subDataList2);

                    Console.WriteLine();
                    Console.WriteLine("관심 과목 총 학점: " + TotalPoint());
                    Console.WriteLine();
                    Console.Write("삭제하려는 강의의 번호를 입력하세요: ");


                    string str = Console.ReadLine();
                    if (str == "\0")
                    {
                        break;
                    }

                    bool isHaveproblem = true;
                    for (int i = 0; i < subDataList2.Count; i++)
                    {
                        if (str == subDataList2[i].no)
                        {
                            allDataList2.Add(subDataList2[i]);  // 삭제하면 관심 과목에 보여주기
                            subDataList2.Remove(subDataList2[i]);
                            isHaveproblem = false;
                            break;
                        }
                    }


                    if (isHaveproblem == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("수강 신청 목록 중에 입력하신 번호에 해당하는 과목이 없습니다. Enter 키를 눌러 다시 입력하세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    Console.WriteLine("삭제가 완료되었습니다");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
            // 2-3 강의 조회
            public void numberTwoInThree()
            {
                ViewList(subDataList2);

                Console.WriteLine();
                Console.WriteLine("내가 수강 신청한 총 학점: " + InterestTotalPoint());  // 총 학점 출력
                Escape();
                Console.Clear();
            }
            // 2-4 강의 전체 목록
            public void numberTwoInFour()
            {
                ViewList(allView);

                Console.WriteLine();
                Escape();
                Console.Clear();
            }







            // 2-5 강의 검색
            public void numberTwoInFive()
            {
                Title.title();
                Console.WriteLine("");
                Console.WriteLine("               >>    1. 개설 학과 전공으로 검색");
                Console.WriteLine("");
                Console.WriteLine("               >>    2. 학수 번호로 검색");
                Console.WriteLine("");
                Console.WriteLine("               >>    3. 교과목 명으로 검색");
                Console.WriteLine("");
                Console.WriteLine("               >>    4. 강의 대상 학년으로 검색");
                Console.WriteLine("");
                Console.WriteLine("               >>    5. 교수명으로 검색");
                Console.WriteLine("");
                Console.WriteLine("               >>    6. 뒤로 가기");
                Console.WriteLine("");
                Console.WriteLine("               >>    7. 종료");
                Console.WriteLine("");
                Console.WriteLine("               원하는 메뉴를 선택해 주세요 :");

                String str = Console.ReadLine();
                Console.Clear();

                switch (str)
                {
                    case "1":
                        numberTwoInFiveInOne();
                        break;
                    case "2":
                        numberTwoInFiveInTwo();
                        break;
                    case "3":
                        numberTwoInFiveInThree();
                        break;
                    case "4":
                        numberTwoInFiveInFour();
                        break;
                    case "5":
                        numberTwoInFiveInFive();
                        break;
                    case "6":
                        numberTwo();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                }
            }


            // 2-5-1 개설 학과 전공으로 검색
            public void numberTwoInFiveInOne()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("개설 학과 전공 이름으로 검색: ");
                List<MainData> searchList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allView.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allView[i].major.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchList.Add(allView[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchList);                //검색한 데이터 보여주기
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
            }
            // 2-5-2 학수 번호로 검색
            public void numberTwoInFiveInTwo()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("개설 학과 전공 이름으로 검색: ");
                List<MainData> searchList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allView.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allView[i].number.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchList.Add(allView[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchList);                //검색한 데이터 보여주기
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
            }
            // 2-5-3 교과목 명으로 검색
            public void numberTwoInFiveInThree()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("개설 학과 전공 이름으로 검색: ");
                List<MainData> searchList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allView.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allView[i].name.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchList.Add(allView[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchList);                //검색한 데이터 보여주기
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
            }
            // 2-5-4 강의 대상 학년으로 검색
            public void numberTwoInFiveInFour()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("개설 학과 전공 이름으로 검색: ");
                List<MainData> searchList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allView.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allView[i].grade.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchList.Add(allView[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchList);                //검색한 데이터 보여주기
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
            }
            // 2-5-5 교수명으로 검색
            public void numberTwoInFiveInFive()
            {
                bool isResult = false;
                Title.title();
                Console.WriteLine("개설 학과 전공 이름으로 검색: ");
                List<MainData> searchList = new List<MainData>();

                while (isResult == false)
                {
                    string str = Console.ReadLine();

                    if (str == "\0")
                    {
                        break;
                    }

                    for (int i = 1; i < allView.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                    {
                        if (allView[i].professor.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                        {
                            searchList.Add(allView[i]);
                            isResult = true;
                        }
                    }

                    if (isResult == false)                        //위 for문의 if문을 통과하지 못하면 실행 
                    {
                        Console.WriteLine();
                        Console.WriteLine("검색 결과가 없습니다. Enter를 눌러 다시 검색해보세요. ");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    }
                    else                                        // isResult이 false가 아니라면 searchedList 를 출력해라
                    {
                        Console.WriteLine();
                        InPutData(searchList);                //검색한 데이터 보여주기
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
            }
        }
    }
}
