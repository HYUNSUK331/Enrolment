using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using Excel = Microsoft.Office.Interop.Excel;   // Excel namespace 참조

using System.Threading.Tasks;
using Enrolment;
using Enrolment.View;
using Enrolment.Model;

namespace Project2

{
    public class MainProgram: Controller1
    {

        static void Main(string[] args)
        {
            MainPage mainPage = new MainPage();
            Controller1.excelSave();  //static으로 만들어두면 처음에 한번 불러올때 완성 되어서 다시 이 화면으로 넘어올때 빠름
            mainPage.mainPage();
            
            /*
            Controller1 con = new Controller1();
            Loading.loading();
            con.excelSave();
            Console.Clear();
            Console.ReadLine();
            con.InPutdata();
            */


            // MainPage.mainPage();
            /*
            for (int i = 0; i < ExcelLoading.allDataList.Count; i++)
            {
                Console.WriteLine(ExcelLoading.allDataList[i].no);
                Console.WriteLine(allDataList[i].major);
            }
            Console.WriteLine();
            Console.ReadLine();
            */

        }
    }

}
