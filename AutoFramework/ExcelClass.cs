using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace AutoFramework
{
    class ExcelClass
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;


        public ExcelClass(string path, int sheet)
        {
            this.path = path;
            workbook = excel.Workbooks.Open(path);
            worksheet = workbook.Worksheets[sheet];
        }

        public string readCell(int col, int row)
        {
            if (worksheet.Cells[col, row].Value2 != null)
                return worksheet.Cells[col, row].Value2;
            else
                return "";
        }

        public void close()
        {
            workbook.Close();
        }
    }
}
