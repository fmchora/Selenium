﻿using System;
using System.Collections.Generic;
using System.IO;
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
            if (File.Exists(@"C:\Users\fmcho\OneDrive\Documents\ApprovalStatusOrg.xls"))
                File.Delete(@"C:\Users\fmcho\OneDrive\Documents\ApprovalStatusOrg.xls");
            this.path = path;
            workbook = excel.Workbooks.Open(path);
            worksheet = workbook.Worksheets[sheet];
        }

        public string readCell(int col, int row)
        {
            if (worksheet.Cells[row, col].Value != null)
                return worksheet.Cells[row, col].value.ToString();
            else
                return null;
        }


        public void  writeCell(int col, int row, string value)
        {
            worksheet.Cells[row, col].Value = value;

        }


        public int getNumberOfColumnsInRow(int row = 2, int start = 1, int end = 50)
        {
            int count = 1;
            for (int i = start; i <= end; i++)
            {
                if (readCell(i, row) != null)
                    count++;
                Console.WriteLine(readCell(i, row));
            }
            return count;
        }

        public void fillOutBatchFile(int row = 2, int howManyRows = 1)
        {
            Dictionary<string, string> batch = getDictionary();
            string data = "";
            int count = 1;

            int totalNumberOfColumns = getNumberOfColumnsInRow(row);

            for (int rows = 1; rows <= howManyRows; rows++)
            {
                Guid id = Guid.NewGuid();

                for (int i = 1; i < totalNumberOfColumns; i++)
                {

                    data = readCell(i, row);
                    if (data.Equals("ID Number") || data.Equals("Organization Name *"))
                    {
                        writeCell(i, row + count, batch.Single(b => b.Key.ToString().Equals(data)).Value.ToString() + id);
                    }
                    else
                    {
                        writeCell(i, row + count, batch.Single(b => b.Key.ToString().Equals(data)).Value.ToString());
                    }
                    Console.WriteLine(batch.Where(d => data.Equals(d.Value)).Count());
                }
                count++;
            }

        }


        public Dictionary<string, string> getDictionary()
        {
            Dictionary<string, string> dictionaryBatch = new Dictionary<string, string>()
            {
            { "DUNS Number", "Felipe se la rifa" },          { "Organization Name *", "ZQXKXRANNSFMXAG" },{ "Country Code *", "US" },
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
            { "Approver Email", "" },                       {"Status", "Charrly triston" }
            };
            return dictionaryBatch;
        }

        public void close()
        {
            workbook.SaveAs();
            workbook.Close();
            excel.Quit();
        }
    }
}
