using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using Excel = Microsoft.Office.Interop.Excel;   // Excel namespace 참조

using System.Threading.Tasks;
using Enrolment;

namespace Project2

{
    class MainProgram
    {
        static void Main(string[] args)
        {
            ExcelSave save = new ExcelSave();
            save.excelSave();
        }

    }

}
