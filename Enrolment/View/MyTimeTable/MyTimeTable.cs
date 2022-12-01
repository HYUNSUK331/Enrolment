using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment.View.MyTimeTable
{
    public class MyTimeTable: Controller1
    {
        
        private static string[,] arr = new string[25, 6];

        public static void myTimeTable()
        {
            MainPage page = new MainPage();
            int column = 0;
            int row = 0;

            Console.WriteLine("      |      월       |       화       |       수       |       목       |       금       |");
            Console.WriteLine("08:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[1, 1], arr[1, 2], arr[1, 3], arr[1, 4], arr[1, 5]);
            Console.WriteLine("");
            Console.WriteLine("08:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[2, 1], arr[2, 2], arr[2, 3], arr[2, 4], arr[2, 5]);
            Console.WriteLine("");
            Console.WriteLine("09:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[3, 1], arr[3, 2], arr[3, 3], arr[3, 4], arr[3, 5]);
            Console.WriteLine("");
            Console.WriteLine("09:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[4, 1], arr[4, 2], arr[4, 3], arr[4, 4], arr[4, 5]);
            Console.WriteLine("");
            Console.WriteLine("10:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[5, 1], arr[5, 2], arr[5, 3], arr[5, 4], arr[5, 5]);
            Console.WriteLine("");
            Console.WriteLine("10:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[6, 1], arr[6, 2], arr[6, 3], arr[6, 4], arr[6, 5]);
            Console.WriteLine("");
            Console.WriteLine("11:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[7, 1], arr[7, 2], arr[7, 3], arr[7, 4], arr[7, 5]);
            Console.WriteLine("");
            Console.WriteLine("11:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[8, 1], arr[8, 2], arr[8, 3], arr[8, 4], arr[8, 5]);
            Console.WriteLine("");
            Console.WriteLine("12:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[9, 1], arr[9, 2], arr[9, 3], arr[9, 4], arr[9, 5]);
            Console.WriteLine("");
            Console.WriteLine("12:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[10, 1], arr[10, 2], arr[10, 3], arr[10, 4], arr[10, 5]);
            Console.WriteLine("");
            Console.WriteLine("13:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[11, 1], arr[11, 2], arr[11, 3], arr[11, 4], arr[11, 5]);
            Console.WriteLine("");
            Console.WriteLine("13:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[12, 1], arr[12, 2], arr[12, 3], arr[12, 4], arr[12, 5]);
            Console.WriteLine("");
            Console.WriteLine("14:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[13, 1], arr[13, 2], arr[13, 3], arr[13, 4], arr[13, 5]);
            Console.WriteLine("");
            Console.WriteLine("14:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[14, 1], arr[14, 2], arr[14, 3], arr[14, 4], arr[14, 5]);
            Console.WriteLine("");
            Console.WriteLine("15:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[15, 1], arr[15, 2], arr[15, 3], arr[15, 4], arr[15, 5]);
            Console.WriteLine("");
            Console.WriteLine("15:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[16, 1], arr[16, 2], arr[16, 3], arr[16, 4], arr[16, 5]);
            Console.WriteLine("");
            Console.WriteLine("16:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[17, 1], arr[17, 2], arr[17, 3], arr[17, 4], arr[17, 5]);
            Console.WriteLine("");
            Console.WriteLine("16:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[18, 1], arr[18, 2], arr[18, 3], arr[18, 4], arr[18, 5]);
            Console.WriteLine("");
            Console.WriteLine("17:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[19, 1], arr[19, 2], arr[19, 3], arr[19, 4], arr[19, 5]);
            Console.WriteLine("");
            Console.WriteLine("17:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[20, 1], arr[20, 2], arr[20, 3], arr[20, 4], arr[20, 5]);
            Console.WriteLine("");
            Console.WriteLine("18:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[21, 1], arr[21, 2], arr[21, 3], arr[21, 4], arr[21, 5]);
            Console.WriteLine("");
            Console.WriteLine("18:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[22, 1], arr[22, 2], arr[22, 3], arr[22, 4], arr[22, 5]);
            Console.WriteLine("");
            Console.WriteLine("19:00 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[23, 1], arr[23, 2], arr[23, 3], arr[23, 4], arr[23, 5]);
            Console.WriteLine("");
            Console.WriteLine("19:30 |-----------------------------------------------------------------------------------|");
            Console.WriteLine("      |     {0}              {1}              {2}              {3}              {4}        ", arr[24, 1], arr[24, 2], arr[24, 3], arr[24, 4], arr[24, 5]);
            Console.WriteLine("");

            for (int i = 0; i < allDataList1.Count; i++)
            {
                for (int j = 0; j < GetTime(allDataList1[i]).Count; j++)
                {
                    switch (GetTime(allDataList1[i])[j])
                    {
                        case 0:
                            column = 20;
                            break;
                        case 1:
                            column = 50;
                            break;
                        case 2:
                            column = 80;
                            break;
                        case 3:
                            column = 110;
                            break;
                        case 4:
                            column = 140;
                            break;
                    }

                    double startTime = GetTime(allDataList1[i])[j + 1];
                    double endTime = GetTime(allDataList1[i])[j + 2];

                    while (startTime != endTime)
                    {
                        switch (startTime)
                        {
                            case 9:
                                row = 11;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 9.5:
                                row = 13;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 10:
                                row = 15;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 10.5:
                                row = 17;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 11:
                                row = 19;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 11.5:
                                row = 21;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 12:
                                row = 23;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 12.5:
                                row = 25;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 13:
                                row = 27;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 13.5:
                                row = 29;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 14:
                                row = 31;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 14.5:
                                row = 33;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 15:
                                row = 35;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 15.5:
                                row = 37;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 16:
                                row = 39;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 16.5:
                                row = 41;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 17:
                                row = 43;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 17.5:
                                row = 45;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 18:
                                row = 47;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 18.5:
                                row = 49;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 19:
                                row = 51;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            case 19.5:
                                row = 53;
                                Console.SetCursorPosition(column, row);
                                Console.WriteLine(allDataList1[i].name);
                                break;
                            default:
                                break;
                        }
                        startTime += 0.5;
                    }

                }
            }
            Console.SetCursorPosition(0, 55);
            Console.WriteLine("뒤로 돌아가려면 ESC를 누르세요.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            page.mainPage();

        }
    }
}
