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
            if (worksheet.Cells[col, row].Value != null)
                return worksheet.Cells[col, row].value.ToString();
            else
                return null;
        }

        public int countIcelumsInRow(int row, int start = 1, int end = 50)
        {
            int count = 1;
            for (int i = start; i <= end; i++)
            {
                if (readCell(row, i) != null)
                    count++;
                Console.WriteLine(readCell(i, row));
            }
            return count;
        }

        public void close()
        {
            workbook.Save();
            workbook.Close();
            excel.Quit();
        }
    }
}
