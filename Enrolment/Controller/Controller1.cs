using Enrolment.Model;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Excel = Microsoft.Office.Interop.Excel;   // Excel namespace 참조
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics.Contracts;
using System.IO;
using Enrolment.View;

public class Controller1
{
    public Array data;
    // 전체 목록에 사용할 리스트
    public static List<MainData> allView = new List<MainData>();
    // 수강신청용 리스트
    public static List<MainData> allDataList1 = new List<MainData>();
    // 관심 과목용 리스트
    public static List<MainData> allDataList2 = new List<MainData>();


    // 수강신청한 목록을 담아둘 리스트 생성
    public static List<MainData> subDataList1 = new List<MainData>();
    // 관심 과목 추가한 목록을 담아둘 리스트 생성 
    public static List<MainData> subDataList2 = new List<MainData>();


    // 엑셀 불러오고 데이터 저장 메서드 
    public static void excelSave()
    {
        Console.WriteLine("▒▒                 ▒▒▒             ▒▒         ▒▒▒▒       ▒▒▒▒▒▒    ▒▒▒       ▒▒       ▒▒▒▒");
        Console.WriteLine("▒▒               ▒▒  ▒▒          ▒▒▒        ▒▒  ▒▒         ▒▒        ▒▒▒▒     ▒▒     ▒▒▒▒▒▒");
        Console.WriteLine("▒▒              ▒▒    ▒▒        ▒▒▒▒       ▒▒    ▒▒       ▒▒        ▒▒ ▒▒    ▒▒    ▒▒");
        Console.WriteLine("▒▒             ▒▒      ▒▒      ▒▒  ▒▒      ▒▒     ▒▒      ▒▒        ▒▒  ▒▒   ▒▒   ▒▒                  ▒▒  ▒▒  ▒▒");
        Console.WriteLine("▒▒             ▒▒      ▒▒     ▒▒    ▒▒     ▒▒     ▒▒      ▒▒        ▒▒   ▒▒  ▒▒   ▒▒   ▒▒▒▒▒     ▒▒  ▒▒  ▒▒");
        Console.WriteLine("▒▒              ▒▒    ▒▒     ▒▒▒▒▒▒▒    ▒▒   ▒▒        ▒▒        ▒▒    ▒▒ ▒▒    ▒▒     ▒▒");
        Console.WriteLine("▒▒▒▒▒▒▒     ▒▒  ▒▒     ▒▒        ▒▒   ▒▒  ▒▒         ▒▒        ▒▒     ▒▒▒▒     ▒▒▒▒▒▒");
        Console.WriteLine("▒▒▒▒▒▒▒       ▒▒▒      ▒▒          ▒▒  ▒▒▒▒       ▒▒▒▒▒▒    ▒▒       ▒▒▒       ▒▒▒  ▒");
    
    Excel.Application ExcelApp = new Excel.Application();

        // Workbook 객체 생성 및 파일 오픈

        Excel.Workbook workbook =// ExcelApp.Workbooks.Open(Environment.GetFolderPath(AppDomain.CurrentDomain.BaseDirectory) + "excelStudy.xlsx");

        ExcelApp.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory + "2020년 1학기 강의시간표.xlsx");

        //sheets에 읽어온 엑셀값을 넣기

        Excel.Sheets sheets = workbook.Sheets;


        // 특정 sheet의 값 가져오기

        Excel.Worksheet worksheet = sheets["Sheet1"] as Excel.Worksheet;

        // 범위 설정
        Excel.Range range = worksheet.UsedRange;    // 사용중인 셀 범위를 가져오기

        // 설정한 범위만큼 데이터 담기
        //string[,] arr1 = new string[160, 10];

        Array data = range.Cells.Value2 as Array;



        for (int i = 1; i <= data.GetLength(0); i++)
        {
            MainData mainData = new MainData();
            mainData.no = Convert.ToString(data.GetValue(i, 1));
            mainData.major = Convert.ToString(data.GetValue(i, 2));
            mainData.number = Convert.ToString(data.GetValue(i, 3));
            mainData.group = Convert.ToString(data.GetValue(i, 4));
            mainData.name = Convert.ToString(data.GetValue(i, 5));
            mainData.split = Convert.ToString(data.GetValue(i, 6));
            mainData.grade = Convert.ToString(data.GetValue(i, 7));
            mainData.point = Convert.ToString(data.GetValue(i, 8));
            mainData.time = Convert.ToString(data.GetValue(i, 9));
            mainData.classroom = Convert.ToString(data.GetValue(i, 10));
            mainData.professor = Convert.ToString(data.GetValue(i, 11));
            mainData.language = Convert.ToString(data.GetValue(i, 12));

            allView.Add(mainData);
            allDataList1.Add(mainData);
            allDataList2.Add(mainData);
        }
        /*
        //이걸 외부로 불면 나가지가 않는다...
        List<string> list = new List<string>();
        for (int i = 1; i <= 11; i++)
        {
            list.Add(Convert.ToString(data.GetValue(1, i) + " | "));
        }
        foreach (string firstLine in list)
        {
            Console.Write(firstLine);
        }

        Console.ReadLine();
        */

        /*
            리스트는 모델 getset으로 담기
             담을때 list[i].major.Contains(검색어)
            콘솔라이트라인으로 하나씩 담기
            list[i]. majar
        */

        ExcelApp.Workbooks.Close();

        ExcelApp.Quit();
        Console.Clear();
    }

    //학점 계산 메서드
    public double TotalPoint()
    {
        double Total = 0;
        for (int i = 0; i < subDataList1.Count; i++)
        {
            Total += double.Parse(subDataList1[i].point);
        }
        return Total;
    }
    //관심항목 학점계산용
    public double InterestTotalPoint()
    {
        double Total = 0;
        for (int i = 0; i < subDataList2.Count; i++)
        {
            Total += double.Parse(subDataList2[i].point);
        }
        return Total;
    }

    // 검색한 과목들이 담길 메서드
    public void InPutData(List<MainData> mainDatas)
    {
        for (int i = 0; i < mainDatas.Count; i++)
        {
            Console.Write(" ");
            Console.Write(mainDatas[i].no);
            Console.Write(" | ");
            Console.Write(mainDatas[i].major);
            Console.Write(" | ");
            Console.Write(mainDatas[i].number);
            Console.Write(" | ");
            Console.Write(mainDatas[i].group);
            Console.Write(" | ");
            Console.Write(mainDatas[i].name);
            Console.Write(" | ");
            Console.Write(mainDatas[i].grade);
            Console.Write(" | ");
            Console.Write(mainDatas[i].point);
            Console.Write(" | ");
            Console.Write(mainDatas[i].time);
            Console.Write(" | ");
            Console.Write(mainDatas[i].classroom);
            Console.Write(" | ");
            Console.Write(mainDatas[i].professor);
            Console.Write(" | ");
            Console.Write(mainDatas[i].language);
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }

    // 계속할지 물어보는 탈출 함수
    // 이걸esc로 바꿀 수 있다면?????
    public void Escape()
    {
        Console.WriteLine();
        Console.WriteLine("ESC를 눌러 이전화면으로 돌아가세요.");
        while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        Console.Clear();
    }

    // 수강 조회 후 신청하기 위한 메서드
    public void EnrollmentList(bool isDone, List<MainData> searchedList)
    {

        while (isDone == false)
        {
            Console.Write("수강신청을 원한는 과목의 번호를 입력하세요!: ");
            bool isHaveproblem = true;       // 문제가 있으면 false로 바꿔주기
            string str = Console.ReadLine();
            Console.Clear();

            if (str == "\0")
            {
                break;
            }

            for (int i = 0; i < searchedList.Count; i++)
            {
                if (searchedList[i].no == str)
                {
                    //학점 초과 문제
                    if (TotalPoint() + double.Parse(searchedList[i].point) > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("21학점을 초과합니다. 다시 입력해보세요. ");
                        isHaveproblem = false;
                        break;
                    }
                    else
                        for (int j = 0; j < subDataList1.Count; j++)
                        {   //학수 번호, 시간이 같은 경우 false로 바꿔주기
                            if (searchedList[i].number == subDataList1[j].number)
                            {
                                Console.WriteLine();
                                Console.WriteLine("학수 번호가 같아 신청할 수 없습니다! ");
                                Console.ReadLine();
                                Console.Clear();
                                isHaveproblem = false;
                                break;
                            }
                            else if (CheckTime(searchedList[i], subDataList1[j]))
                            {
                                Console.WriteLine();
                                Console.WriteLine("기존 신청 과목과 시간이 겹칩니다. 다시 입력해보세요. ");
                                Console.ReadLine();
                                Console.Clear();
                                isHaveproblem = false;
                                break;
                            }
                        }
                    if (isHaveproblem == true)
                    {
                        subDataList1.Add(searchedList[i]); // 수강신청 목록 담기
                        allDataList1.Remove(searchedList[i]); // 전체 데이터에서 삭제 하면 어디서든 안보임
                        allDataList2.Remove(searchedList[i]); // 위와 동일하지만 관심과목용
                        Console.WriteLine();
                        Console.WriteLine("  수강신청 !!성공!!");
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
    // 수강 조회 후 관심항목에 넣기
    public void InterestList(bool isDone, List<MainData> searchedList)
    {

        while (isDone == false)
        {
            Console.Write("수강신청을 원한는 과목의 번호를 입력하세요!: ");
            bool isHaveproblem = true;       // 문제가 있으면 false로 바꿔주기
            string str = Console.ReadLine();
            Console.Clear();

            if (str == "\0")
            {
                break;
            }

            for (int i = 0; i < searchedList.Count; i++)
            {
                if (searchedList[i].no == str)
                {
                    //학점 초과 문제
                    if (InterestTotalPoint() + double.Parse(searchedList[i].point) > 24)
                    {
                        Console.WriteLine();
                        Console.WriteLine("24학점을 초과합니다. 다시 입력해보세요. ");
                        isHaveproblem = false;
                        break;
                    }
                    else
                        for (int j = 0; j < subDataList2.Count; j++)
                        {   //학수 번호, 시간이 같은 경우 false로 바꿔주기
                            if (searchedList[i].number == subDataList2[j].number)
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
                        subDataList2.Add(searchedList[i]); // 수강신청 목록 담기
                        allDataList2.Remove(searchedList[i]); // 관심 과목 리스트에서만 지우기
                        Console.WriteLine();
                        Console.WriteLine("  수강신청 !!성공!!");
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
    // 저장된 리스트를 보여주는 메서드 
    public void ViewList(List<MainData> a)
    {
        Title.title();
        for (int i = 0; i < a.Count; i++)
        {
            Console.Write(" ");
            Console.Write(a[i].no);
            Console.Write(" | ");
            Console.Write(a[i].major);
            Console.Write(" | ");
            Console.Write(a[i].number);
            Console.Write(" | ");
            Console.Write(a[i].group);
            Console.Write(" | ");
            Console.Write(a[i].name);
            Console.Write(" | ");
            Console.Write(a[i].grade);
            Console.Write(" | ");
            Console.Write(a[i].point);
            Console.Write(" | ");
            Console.Write(a[i].time);
            Console.Write(" | ");
            Console.Write(a[i].classroom);
            Console.Write(" | ");
            Console.Write(a[i].professor);
            Console.Write(" | ");
            Console.Write(a[i].language);
            Console.WriteLine("");
        }
    }

    /*실패작
    public static List<double> GetTime(MainData mainData)
    {
        char[] deleteWord = { ' ', '~', ':', ',' };

        List<double> dayTime = new List<double>();

        string[] timeSplit = mainData.time.Split(',');
        string[] timeSplit1 = timeSplit[0].Split(' ');
        
        if (timeSplit.Length == 2)
        {
            string[] timeSplit2 = timeSplit[1].Split(' ');
        }

        for (int i = 0; i < timeSplit.Length; i++)
        {
            switch (timeSplit[i])
            {
                case "월":
                    dayTime.Add(1);
                    break;
                case "화":
                    dayTime.Add(2);
                    break;
                case "수":
                    dayTime.Add(3);
                    break;
                case "목":
                    dayTime.Add(4);
                    break;
                case "금":
                    dayTime.Add(5);
                    break;
                default:
                    break;

            }
            
            i++;
            string[] timeSplit2 = timeSplit1[i].Split('~');
            string[] timeSplit3 = timeSplit2[0].Split(':');
            string[] timeSplit4 = timeSplit2[1].Split(':');

            for (int j = 0; j < 2; j++)
            {
                if (timeSplit3[j] == "00")
                {
                    timeSplit3[j] = "0";
                }
                else if (timeSplit3[j] == "30")
                {
                    timeSplit3[j] = "0.5";
                }
                else { }

                if (timeSplit4[j] == "00")
                {
                    timeSplit4[j] = "0";
                }
                else if (timeSplit4[j] == "30")
                {
                    timeSplit4[j] = "0.5";
                }
                else { }
            }
            double startTime = int.Parse(timeSplit3[0]) + double.Parse(timeSplit3[1]);
            double endTime = int.Parse(timeSplit4[0]) + double.Parse(timeSplit4[1]);
            dayAndTime.Add(startTime);
            dayAndTime.Add(endTime);
            
        }

        return dayTime;

    }
    */

    //날짜,시간 전부 규칙적인 숫자로 바꿔주기 
    public static List<double> GetTime(MainData mainData)

    {
        List<double> dayAndTime = new List<double>();

        string[] timeSplit = mainData.time.Split(',');


        // <화 18:00~19:00>, <화 목 13:30~15:00> timeSplit으로 나누면 둘중 하나만 들어온다.
        if (timeSplit.Length == 1)
        {

            string[] timeSplit1 = timeSplit[0].Split(' '); // ',' 가 없으면 [0]은 <화 18:00~19:00> 전체

            // 화 18:00~19:00   길이가 2인 경우는 하나
            // 출력 값 1, 13.5, 15.0
            if (timeSplit1.Length == 2)
            {
                for (int i = 0; i < timeSplit1.Length - 1; i++)
                {
                    switch (timeSplit1[i])
                    {
                        case "월":
                            dayAndTime.Add(0);
                            break;
                        case "화":
                            dayAndTime.Add(1);
                            break;
                        case "수":
                            dayAndTime.Add(2);
                            break;
                        case "목":
                            dayAndTime.Add(3);
                            break;
                        case "금":
                            dayAndTime.Add(4);
                            break;
                        default:
                            break;
                    }
                    string[] timeSplit2 = timeSplit1[1].Split('~'); // 요일을 뺀 시간에서 ~를 기주능로 나누기
                    string[] timeSplit3 = timeSplit2[0].Split(':'); // 앞쪽 (startTime)를 나누기
                    string[] timeSplit4 = timeSplit2[1].Split(':'); // 뒷쪽 (endTime)를 나누기

                    for (int j = 1; j < timeSplit3.Length; j++)
                    {
                        if (timeSplit3[j] == "00") // 앞 double형태로 만들기
                        {
                            timeSplit3[j] = "0";
                        }
                        else if (timeSplit3[j] == "30")
                        {
                            timeSplit3[j] = "0.5";
                        }
                        else { }

                        if (timeSplit4[j] == "00") // 뒤 double형태로 만들기
                        {
                            timeSplit4[j] = "0";
                        }
                        else if (timeSplit4[j] == "30")
                        {
                            timeSplit4[j] = "0.5";
                        }
                        else { }
                    }
                    double startTime = int.Parse(timeSplit3[0]) + double.Parse(timeSplit3[1]); // 앞(startTime) 더해주기 
                    double endTime = int.Parse(timeSplit4[0]) + double.Parse(timeSplit4[1]);   // 뒤(endTime) 더해주기 
                    dayAndTime.Add(startTime);
                    dayAndTime.Add(endTime);
                }
            }

            // 화 목 13:30~15:00
            // 출력 값 1, 13.5, 15.0, 3, 13.5, 15.0
            else if (timeSplit1.Length == 3)
            {

                for (int i = 0; i < timeSplit1.Length - 1; i++)
                {
                    if (timeSplit1[i] == "월")  //case 사용 못함 2가지의 요일이 들어오기 때문에
                    {
                        dayAndTime.Add(0);
                    }
                    else if (timeSplit1[i] == "화")
                    {
                        dayAndTime.Add(1);
                    }
                    else if (timeSplit1[i] == "수")
                    {
                        dayAndTime.Add(2);
                    }
                    else if (timeSplit1[i] == "목")
                    {
                        dayAndTime.Add(3);
                    }
                    else if (timeSplit1[i] == "금")
                    {
                        dayAndTime.Add(4);
                    }

                    string[] timeSplit2_4 = timeSplit1[2].Split('~');
                    string[] timeSplit3_4 = timeSplit2_4[0].Split(':');
                    string[] timeSplit4_4 = timeSplit2_4[1].Split(':');

                    for(int j = 1; j < timeSplit3_4.Length; j++)
                    {
                        if (timeSplit3_4[j] == "00")
                        {
                            timeSplit3_4[j] = "0";
                        }
                        else if (timeSplit3_4[j] == "30")
                        {
                            timeSplit3_4[j] = "0.5";
                        }
                        
                        if (timeSplit4_4[j] == "00")
                        {
                            timeSplit4_4[j] = "0";
                        }
                        else if (timeSplit4_4[j] == "30")
                        {
                            timeSplit4_4[j] = "0.5";
                        }
                    }
                    double startTime = int.Parse(timeSplit3_4[0]) + double.Parse(timeSplit3_4[1]); // 앞(startTime) 더해주기 
                    double endTime = int.Parse(timeSplit4_4[0]) + double.Parse(timeSplit4_4[1]);   // 뒤(endTime) 더해주기 
                    dayAndTime.Add(startTime);
                    dayAndTime.Add(endTime);
                }

            }
        }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


        // <월 수 09:00~10:30, 수 18:00~20:00>, <금 09:00~12:00, 금 13:00~15:00>
        else if (timeSplit.Length == 2)  // ','를 기준으로 2가지로 나뉜경우
        {
            string[] timeSplit1_1 = timeSplit[0].Split(' ');
            string[] timeSplit1_2 = timeSplit[1].Split(' ');
            bool check = true;
            // < 금 09:00~12:00 / 금 13:00~15:00 >
            if (timeSplit1_1.Length == 2 && check == true )
            {
                for (int i = 0; i < timeSplit1_1.Length - 1; i++)
                {
                    switch (timeSplit1_1[i])
                    {
                        case "월":
                            dayAndTime.Add(0);
                            break;
                        case "화":
                            dayAndTime.Add(1);
                            break;
                        case "수":
                            dayAndTime.Add(2);
                            break;
                        case "목":
                            dayAndTime.Add(3);
                            break;
                        case "금":
                            dayAndTime.Add(4);
                            break;
                        default:
                            break;
                    }


                    string[] timeSplit2 = timeSplit1_1[1].Split('~');
                    string[] timeSplit3 = timeSplit2[0].Split(':');
                    string[] timeSplit4 = timeSplit2[1].Split(':');

                    for (int j = 0; j < 2; j++)
                    {
                        if (timeSplit3[j] == "00")
                        {
                            timeSplit3[j] = "0";
                        }
                        else if (timeSplit3[j] == "30")
                        {
                            timeSplit3[j] = "0.5";
                        }
                        else { }

                        if (timeSplit4[j] == "00")
                        {
                            timeSplit4[j] = "0";
                        }
                        else if (timeSplit4[j] == "30")
                        {
                            timeSplit4[j] = "0.5";
                        }
                        else { }
                    }
                    double startTime = int.Parse(timeSplit3[0]) + double.Parse(timeSplit3[1]);
                    double endTime = int.Parse(timeSplit4[0]) + double.Parse(timeSplit4[1]);
                    dayAndTime.Add(startTime);
                    dayAndTime.Add(endTime);
                    check = false;
                }

                // 한번 더 진핸 하지만  ',' 뒤의 시간표 더해주기
               
                for (int i = 1; i < timeSplit1_2.Length - 1; i++)
                {
                    switch (timeSplit1_2[i])
                    {
                        case "월":
                            dayAndTime.Add(0);
                            break;
                        case "화":
                            dayAndTime.Add(1);
                            break;
                        case "수":
                            dayAndTime.Add(2);
                            break;
                        case "목":
                            dayAndTime.Add(3);
                            break;
                        case "금":
                            dayAndTime.Add(4);
                            break;
                        default:
                            break;
                    }


                    string[] timeSplit2_2 = timeSplit1_2[2].Split('~');
                    string[] timeSplit3_2 = timeSplit2_2[0].Split(':');
                    string[] timeSplit4_2 = timeSplit2_2[1].Split(':');

                    for (int j = 1; j < 2; j++)
                    {
                        if (timeSplit3_2[j] == "00")
                        {
                            timeSplit3_2[j] = "0";
                        }
                        else if (timeSplit3_2[j] == "30")
                        {
                            timeSplit3_2[j] = "0.5";
                        }
                        else { }

                        if (timeSplit4_2[j] == "00")
                        {
                            timeSplit4_2[j] = "0";
                        }
                        else if (timeSplit4_2[j] == "30")
                        {
                            timeSplit4_2[j] = "0.5";
                        }
                        else { }
                    }
                    double startTime = int.Parse(timeSplit3_2[0]) + double.Parse(timeSplit3_2[1]);
                    double endTime = int.Parse(timeSplit4_2[0]) + double.Parse(timeSplit4_2[1]);
                    dayAndTime.Add(startTime);
                    dayAndTime.Add(endTime);
                }

            }


            // <월 수 09:00~10:30, 수 18:00~20:00>
            else if (timeSplit1_1.Length == 3)
            {
                for (int i = 0; i < timeSplit1_1.Length - 1; i++)
                {
                    if (timeSplit1_1[i] == "월")  //case 사용 못함 2가지의 요일이 들어오기 때문에
                    {
                        dayAndTime.Add(0);
                    }
                    else if (timeSplit1_1[i] == "화")
                    {
                        dayAndTime.Add(1);
                    }
                    else if (timeSplit1_1[i] == "수")
                    {
                        dayAndTime.Add(2);
                    }
                    else if (timeSplit1_1[i] == "목")
                    {
                        dayAndTime.Add(3);
                    }
                    else if (timeSplit1_1[i] == "금")
                    {
                        dayAndTime.Add(4);
                    }


                    string[] timeSplit2_2 = timeSplit1_1[2].Split('~');
                    string[] timeSplit3_2 = timeSplit2_2[0].Split(':');
                    string[] timeSplit4_2 = timeSplit2_2[1].Split(':');

                    for (int j = 0; j < 2; j++)
                    {
                        if (timeSplit3_2[j] == "00")
                        {
                            timeSplit3_2[j] = "0";
                        }
                        else if (timeSplit3_2[j] == "30")
                        {
                            timeSplit3_2[j] = "0.5";
                        }
                        else { }

                        if (timeSplit4_2[j] == "00")
                        {
                            timeSplit4_2[j] = "0";
                        }
                        else if (timeSplit4_2[j] == "30")
                        {
                            timeSplit4_2[j] = "0.5";
                        }
                        else { }
                    }
                    double startTime = int.Parse(timeSplit3_2[0]) + double.Parse(timeSplit3_2[1]);
                    double endTime = int.Parse(timeSplit4_2[0]) + double.Parse(timeSplit4_2[1]);
                    dayAndTime.Add(startTime);
                    dayAndTime.Add(endTime);
                    check = false;
                }

                // 한번 더 진핸 하지만  ',' 뒤의 시간표 더해주기

                for (int i = 1; i < timeSplit1_2.Length - 1; i++)
                {
                    switch (timeSplit1_2[i])
                    {
                        case "월":
                            dayAndTime.Add(0);
                            break;
                        case "화":
                            dayAndTime.Add(1);
                            break;
                        case "수":
                            dayAndTime.Add(2);
                            break;
                        case "목":
                            dayAndTime.Add(3);
                            break;
                        case "금":
                            dayAndTime.Add(4);
                            break;
                        default:
                            break;
                    }


                    string[] timeSplit2_2 = timeSplit1_2[2].Split('~');
                    string[] timeSplit3_2 = timeSplit2_2[0].Split(':');
                    string[] timeSplit4_2 = timeSplit2_2[1].Split(':');

                    for (int j = 1; j < 2; j++)
                    {
                        if (timeSplit3_2[j] == "00")
                        {
                            timeSplit3_2[j] = "0";
                        }
                        else if (timeSplit3_2[j] == "30")
                        {
                            timeSplit3_2[j] = "0.5";
                        }
                        else { }

                        if (timeSplit4_2[j] == "00")
                        {
                            timeSplit4_2[j] = "0";
                        }
                        else if (timeSplit4_2[j] == "30")
                        {
                            timeSplit4_2[j] = "0.5";
                        }
                        else { }
                    }
                    double startTime = int.Parse(timeSplit3_2[0]) + double.Parse(timeSplit3_2[1]);
                    double endTime = int.Parse(timeSplit4_2[0]) + double.Parse(timeSplit4_2[1]);
                    dayAndTime.Add(startTime);
                    dayAndTime.Add(endTime);
                }
            }
        }

        return dayAndTime;
    }

    //실험용
    public static void TimeCheck()
    {
        Console.WriteLine(GetTime(allDataList1[2]));
        Console.WriteLine(GetTime(allDataList1[2]).Count);  // = 3
        Console.WriteLine(GetTime(allDataList1[24]));
        Console.WriteLine(GetTime(allDataList1[24]).Count);  // = 6 
        Console.WriteLine(GetTime(allDataList1[115]));
        Console.WriteLine(GetTime(allDataList1[115]).Count); // = 6
        Console.WriteLine(GetTime(allDataList1[116]));
        Console.WriteLine(GetTime(allDataList1[116]).Count); // = 6
    }

    // 시간 중복 체크하는 메서드
    public bool CheckTime(MainData mainData, MainData mainData1)
    {
        bool isOverlapped = false;
        for (int i = 0; i < GetTime(mainData).Count; i += 3)
        {
            for (int j = 0; j < GetTime(mainData1).Count; j += 3)
            {
                if (GetTime(mainData)[i] == GetTime(mainData1)[j])
                {
                    // 겹치면 아웃 
                    if ((GetTime(mainData)[i + 2] > GetTime(mainData1)[j + 1]) && (GetTime(mainData)[i + 1] < GetTime(mainData1)[j + 2]))
                    {
                        isOverlapped = true;
                    }
                    else { }
                }
                else { }
            }
        }

        return isOverlapped;
    }
    /*강의 검색 메서드
    public void ClassSerch(String a)
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
                //여기에 a사용 하고싶은데 안돼!!!!!
                if (allDataList1[i].a.Contains(str))
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
    */

}
