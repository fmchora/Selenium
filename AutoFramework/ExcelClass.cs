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

        public Dictionary<string, string> returnDictionary()
        {
            Dictionary<string, string> dictionaryBatch = new Dictionary<string, string>()
            {
            { "DUNS Number", " " },                          { "Organization Name *", "ZQXKXRANNSFMXAG" },{ "Country Code *", "US" },
            { "Address 1", " " },                            { "Address 2", " " },                        { "City", "Idaho" },
            { "State/Province Code", "ID" },                 { "Postal Code", "" },                       { "Category *", "SUP" },
            { "Contract Amount", "1000" },                   { "Internal Department", "FBI" },            { "Subsidiary/Parent", "Parent" },
            { "Branch/Division *", "Internal Department 1" },{ "Contract Expiration Date", "7/21/2017" }, { "Start Date of Relationship", "7/21/2017" },
            { "State Owned Entity", "No" },                  { "Ownership by a Public Official", "No" },  { "Interacts with Government Entities", "No" },
            { "Third Party Payment Type", "Visa" },          { "Financial Risk", "No" },                  { "IT Security Risk", "No" },
            { "Tax ID", "" },                                { "Business Registration Number", "" },      { "ID Number", "" },
            { "Billed To", "" },                             { "Approval Status *", "" },                 { "Contact Company Name", "ZQXKXRANNSFMXAG" },
            { "Contact Title", "" },                         { "Contact First Name", "" },                { "Contact Middle Name", "" },
            { "Contact Last Name", "" },                     { "Contact Phone", "" },                     { "Contact Email", "" },
            { "Contact Country Code", "US" },                { "Contact Address 1", "" },                 { "Contact Address 2", "" },
            { "Contact City", "" },                          { "Contact State/Province Code", "ID" },     { "Contact Postal Code", "" },
            { "Contact Language Code", "" },                 { "Third Party ID", "" },                    { "Owner Email *", "threepqa+level1@gmail.com" },
            { "Approver Email", "" },                       {"Status", "" }
            };
            return dictionaryBatch;
        }

        public void close()
        {
            workbook.Save();
            workbook.Close();
            excel.Quit();
        }
    }
}
