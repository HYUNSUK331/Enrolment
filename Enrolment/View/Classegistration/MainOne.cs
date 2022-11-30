using Enrolment.Model;
using Enrolment.View.InterestedClass.Enrolment.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// 1
namespace Enrolment.View
{
    public class MainOne : Controller1
    {
        private static MainOne numberInstance = null;

        public static MainOne Instance                                   //싱글톤 패턴으로 선언
        {
            get
            {
                if (numberInstance == null)
                    numberInstance = new MainOne();
                return numberInstance;
            }
        }

        // 1. 수강신청 
        public void numberOne()
        {
            MainPage mainPage = new MainPage();
            while (true)
            {
                Title.title();
                Console.WriteLine("");
                Console.WriteLine("                             >> 1. 수강 강의 추가");
                Console.WriteLine("");
                Console.WriteLine("                             >> 2. 수강 강의 삭제");
                Console.WriteLine("");
                Console.WriteLine("                             >> 3. 수강 강의 조회");
                Console.WriteLine("");
                Console.WriteLine("                             >> 4. 수강 강의 전체 목록");
                Console.WriteLine("");
                Console.WriteLine("                             >> 5. 강의 검색");
                Console.WriteLine("");
                Console.WriteLine("                             >> 6. 처음 메뉴 돌아가기");
                Console.WriteLine("");
                Console.WriteLine("                             >> 7. 종     료 ");
                Console.WriteLine("");
                Console.Write("                            원하는 메뉴를 선택해 주세요 :");

                string str = ReadLine();

                Console.Clear();

                if (str == "\0")
                {
                    break;
                }
                switch (str)    //다음페이지 안에서도 변하는게 없어서 static 사용
                {
                    case "1":
                        numberOneInOne();
                        break;
                    case "2":
                        numberTwo();
                        break;
                    case "3":
                        numberThree();
                        break;
                    case "4":
                        numberFour();
                        break;
                    case "5":
                        numberFive();
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


        // 1-1 수강강의 추가 
        public void numberOneInOne()
        {
            Console.Clear();

            Title.title();
            Console.WriteLine("");
            Console.WriteLine("               >> 1. 개설 학과 전공으로 검색하여 수강 신청 <<");
            Console.WriteLine("");
            Console.WriteLine("               >>    2. 학수 번호로 검색하여 수강 신청     <<");
            Console.WriteLine("");
            Console.WriteLine("               >>    3. 교과목 명으로 검색하여 수강 신청   <<");
            Console.WriteLine("");
            Console.WriteLine("               >> 4. 강의 대상 학년으로 검색하여 수강 신청 << ");
            Console.WriteLine("");
            Console.WriteLine("               >>     5. 교수명으로 검색하여 수강 신청     <<");
            Console.WriteLine("");
            Console.WriteLine("               >>    6. 관심 과목으로 검색하여 수강 신청   <<");
            Console.WriteLine("");
            Console.WriteLine("                            >> 7. 뒤로 가기 <<");
            Console.WriteLine("");
            Console.WriteLine("                              >> 8. 종료 <<");
            Console.WriteLine("");
            Console.WriteLine("                       원하는 메뉴를 선택해 주세요 :");

            String str = ReadLine();
            Console.Clear();

            switch (str)
            {
                case "1":
                    numberOneInOneInOne();
                    break;
                case "2":
                    numberOneInOneInTwo();
                    break;
                case "3":
                    numberOneInOneInThree();
                    break;
                case "4":
                    numberOneInOneInFour();
                    break;
                case "5":
                    numberOneInOneInFive();
                    break;
                case "6":
                    numberOneInOneInSix();
                    break;
                case "7":
                    numberOne();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
            }
        }


        // 1-1-1 개설 학과 전공으로 검색하여 수강신청
        public void numberOneInOneInOne()
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

                for (int i = 1; i < allDataList1.Count; i++)
                {
                    if (allDataList1[i].major.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                    {
                        searchedList.Add(allDataList1[i]);
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
                EnrollmentList(isDone, searchedList);
            }

        }
        // 1-1-2 학수 번호로 검색하여 수강신청
        public void numberOneInOneInTwo()
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

                for (int i = 1; i < allDataList1.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                {
                    if (allDataList1[i].number.Contains(str))
                    {
                        searchedList.Add(allDataList1[i]);
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
                EnrollmentList(isDone, searchedList);
            }

        }
        // 1-1-3 교과목 명으로 검색하여 수강신청
        public void numberOneInOneInThree()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("교과목 명으로 검색: ");
            List<MainData> searchedList = new List<MainData>();

            while (isResult == false)
            {
                string str = Console.ReadLine();

                if (str == "\0")
                {
                    break;
                }

                for (int i = 1; i < allDataList1.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                {
                    if (allDataList1[i].name.Contains(str))
                    {
                        searchedList.Add(allDataList1[i]);
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
                EnrollmentList(isDone, searchedList);
            }
        }
        // 1-1-4 강의 대상 학년으로 검색하여 수강신청
        public void numberOneInOneInFour()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("강의 대상 학년으로 검색: ");
            List<MainData> searchedList = new List<MainData>();

            while (isResult == false)
            {
                string str = Console.ReadLine();

                if (str == "\0")
                {
                    break;
                }

                for (int i = 1; i < allDataList1.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                {
                    if (allDataList1[i].grade.Contains(str))
                    {
                        searchedList.Add(allDataList1[i]);
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
                EnrollmentList(isDone, searchedList);
            }
        }
        // 1-1-5 교수명으로 검색하여 수강신청
        public void numberOneInOneInFive()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("교수명으로 검색: ");
            List<MainData> searchedList = new List<MainData>();

            while (isResult == false)
            {
                string str = Console.ReadLine();

                if (str == "\0")
                {
                    break;
                }

                for (int i = 1; i < allDataList1.Count; i++)   // allDataList.Count 사용ㅇ하면 배열 2번 순회
                {
                    if (allDataList1[i].professor.Contains(str))
                    {
                        searchedList.Add(allDataList1[i]);
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
                EnrollmentList(isDone, searchedList);
            }
        }
        // 1-1-6 관심 과목으로 검색하여 수강신청
        public void numberOneInOneInSix()
        {

            while (true)
            {
                bool isHaveproblem = true;
                ViewList(MainTwo.subDataList2);  // 이걸 왜 써야 할까??? 싱글 톤때문이라고 해도 데이터는 controller에 저장 된거 아닌가???
                Console.WriteLine();
                Console.WriteLine("내가 수강 신청한 총 학점: " + InterestTotalPoint());  // 총 학점 출력
                Console.WriteLine("수강신청을 원하는 번호를 입력하세요!: ");
                string str = Console.ReadLine();

                List<MainData> searchedList = new List<MainData>();

                for (int i = 1; i < allDataList1.Count; i++)  // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ 
                {                                               // 과연 1 때문인지 아니면 다른 데이터 인지...?
                    if (allDataList1[i].no.Contains(str))  //메이저를 메게변수로 넣을 수 있으면 좋겠다....
                    {
                        searchedList.Add(allDataList1[i]);
                    }
                }

                for (int i = 0; i < subDataList2.Count; i++)   
                {
                    if (subDataList2[i].no == str)
                    {
                        if (TotalPoint() + double.Parse(subDataList2[i].point) > 24)
                        {
                            Console.WriteLine();
                            Console.WriteLine("24학점을 초과합니다. 다시 입력해보세요. ");
                            isHaveproblem = false;
                            break;
                        }
                        else
                            for (int j = 0; j < subDataList1.Count; j++)
                            {   //학수 번호, 시간이 같은 경우 false로 바꿔주기
                                if (subDataList2[i].number == subDataList1[j].number)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("학수 번호가 같아 신청할 수 없습니다! ");
                                    Console.ReadLine();
                                    Console.Clear();
                                    isHaveproblem = false;
                                    break;
                                }
                            }
                        if (isHaveproblem == true)
                        {
                            subDataList1.Add(subDataList2[i]); // 수강신청 목록 담기
                            subDataList2.Remove(subDataList2[i]);
                            allDataList2.Remove(searchedList[i]);
                            allDataList1.Remove(searchedList[i]); // 전체 데이터에서 삭제 하면 어디서든 안보임 
                            Console.WriteLine();
                            Console.WriteLine("  수강신청 !! 성공!!");
                            Console.WriteLine("   Enter를 눌러주세요.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    }
                }
                break;
            }
        }


        //1-2 강의 삭제
        public void numberTwo()
        {
            while (true)
            {
                ViewList(subDataList1);

                Console.WriteLine();
                Console.WriteLine(" 총 학점: " + TotalPoint());
                Console.WriteLine();
                Console.Write("삭제하려는 강의의 번호를 입력하세요: ");

                
                string str = Console.ReadLine();
                if (str == "\0")
                {
                    break;
                }
                bool isHaveproblem = true;
                for (int i = 0; i < subDataList1.Count; i++)
                {
                    if (str == subDataList1[i].no)
                    {
                        allDataList1.Add(subDataList1[i]); // 삭제하면 수강 신청에 보여주기
                        allDataList2.Add(subDataList1[i]);  // 삭제하면 관심 과목에도 보여주기
                        subDataList1.Remove(subDataList1[i]);
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

        //1-3 강의 조회
        public void numberThree()
        {
            ViewList(subDataList1);

            Console.WriteLine();
            Console.WriteLine("내가 수강 신청한 총 학점: " + TotalPoint());  // 총 학점 출력
            Escape();
            Console.Clear();
        }

        //1-4 강의 전체 목록
        public void numberFour()
        {
            ViewList(allView);

            Console.WriteLine();
            Escape();
            Console.Clear();
        }





        //1-5 강의 검색
        public void numberFive()
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

            String str = ReadLine();
            Console.Clear();

            switch (str)
            {
                case "1":
                    numberOneInFiveInOne();
                    break;
                case "2":
                    numberOneInFiveInTwo();
                    break;
                case "3":
                    numberOneInFiveInThree();
                    break;
                case "4":
                    numberOneInFiveInFour();
                    break;
                case "5":
                    numberOneInFiveInFive();
                    break;
                case "6":
                    numberOne();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;

            }
        }


        //1-5-1 개설 학과 전공으로 검색
        public void numberOneInFiveInOne()
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
        //1-5-2 학수 번호로 검색
        public void numberOneInFiveInTwo()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("학수 번호로 검색: ");
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
        //1-5-3 교과목 명으로 검색
        public void numberOneInFiveInThree()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("교과목 명으로 검색: ");
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
        //1-5-4 강의 대상 학년으로 검색
        public void numberOneInFiveInFour()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("대상 학년으로 검색: ");
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
        //1-5-5 교수명으로 검색
        public void numberOneInFiveInFive()
        {
            bool isResult = false;
            Title.title();
            Console.WriteLine("교수 이름으로 검색: ");
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
