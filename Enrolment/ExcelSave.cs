using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;   // Excel namespace 참조
using System.Runtime.InteropServices;

namespace Enrolment
{
    class ExcelSave
    {
        public void excelSave()
        {
            try
            {
                //open

                //  Excel Application 객체 생성

                Excel.Application ExcelApp = new Excel.Application();

                // Workbook 객체 생성 및 파일 오픈

                Excel.Workbook workbook =// ExcelApp.Workbooks.Open(Environment.GetFolderPath(AppDomain.CurrentDomain.BaseDirectory) + "excelStudy.xlsx");

                ExcelApp.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory + "2020년 1학기 강의시간표.xlsx");

                //sheets에 읽어온 엑셀값을 넣기

                Excel.Sheets sheets = workbook.Sheets;


                // 특정 sheet의 값 가져오기

                Excel.Worksheet worksheet = sheets["Sheet1"] as Excel.Worksheet;



                // 범위 설정

                Excel.Range cellRange = worksheet.get_Range("A1", "L161") as Excel.Range;


                // 설정한 범위만큼 데이터 담기

                Array data = cellRange.Cells.Value2 as Array;



                // 데이터 출력

                Console.WriteLine(data.GetValue(1,1));

                ExcelApp.Workbooks.Close();

                ExcelApp.Quit();

                //save 

                //  Excel Application 객체 생성
                /*
                Excel.Application excelappSaveTimbTable = new Excel.Application();
                Excel.Workbook workbookSaveTimbTable = excelappSaveTimbTable.Workbooks.Add(Type.Missing);
                Excel.Worksheet excelWorksheetSaveTimbTable = (Excel.Worksheet)excelappSaveTimbTable.Worksheets.get_Item(1);  // 시트첫번째
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                excelWorksheetSaveTimbTable.Cells[1, 1] = "12323424";

                Excel.Range cellRange = excelWorksheetSaveTimbTable.get_Range("A1", "F25") as Excel.Range;
                cellRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                excelWorksheetSaveTimbTable.Columns.EntireColumn.AutoFit();
                workbookSaveTimbTable.SaveAs(desktopPath + "\\MyLectureTimeTable.xls", Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                workbookSaveTimbTable.Close(false, Type.Missing, Type.Missing);
                 */
            }

            catch (SystemException e)

            {

                Console.WriteLine(e.Message);

            }
        }
    }
}
