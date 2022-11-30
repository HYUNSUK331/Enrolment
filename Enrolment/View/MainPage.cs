using Enrolment.Model;
using Enrolment.View.MyTimeTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Enrolment.View.InterestedClass.Enrolment.View;
//main
namespace Enrolment.View
{
    class MainPage:Controller1
    {
        // view 4개로 줄이기
        // 1번에 관한 뷰가 전부 담겨있는 신청
        // 2번에 관한 뷰가 전부 담겨있는 신청
        // 3번에 관한 뷰가 전부 담겨있는 신청
        // 4번에 관한 뷰가 전부 담겨있는 신청
        // 수강 신청을 아빠로!! 관심과목을 아들로!!!! 상속은 무조건 다 써야 된다. 
        public void mainPage()
        {

            while (true)
            {
                Title.title();
                WriteLine("");
                WriteLine("                             >> 1. 수 강 신 청");
                WriteLine("");
                WriteLine("                             >> 2. 관 심 과 목");
                WriteLine("");
                WriteLine("                             >> 3. 나의 시간표");
                WriteLine("");
                WriteLine("                             >> 4. 종       료");
                WriteLine("");
                Write("                          원하는 메뉴를 선택해 주세요 :");

                string str = Console.ReadLine();
                Console.Clear();
                // if를 사용하면 예외처리가 매우 복잡하고 힘들어진다...
                switch (str)
                {
                    case "1":
                        MainOne.Instance.numberOne();
                        break;
                    case "2":
                        MainTwo.Instance.numberTwo();
                        break;
                    case "3":
                        MyTimeTable.MyTimeTable.myTimeTable();
                        break;
                    case "4":
                        Controller1.TimeCheck();
                        Console.ReadLine();
                        //Environment.Exit(0);   //바로 콘솔 닫아버리기
                        break;
                }
            }
        }
    }
}
