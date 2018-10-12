using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace AutoFramework
{
    class batchUpload
    {
        IAlert alert;
        [OneTimeSetUp]
        public void Initialize()
        {
            //Actions.InitializeDriver("https://www.google.com/");
        }

        [TestCase]
        public void readFile()
        {
            ExcelClass excelFile = new ExcelClass(@"D:\TrabajoFolder\bulkUpload\ApprovalStatusOrg.xls", 1);
            //Console.WriteLine(excelFile.readCell(1,3));
           // excelFile.writeCell(1,3,"felipe");
            //excelFile.getNumberOfColumnsInRow(2);
            excelFile.fillOutBatchFile(2);
            excelFile.close();
        }

        [TestCase]
        public void writeFile()
        {

        }

        [TestCase]
        public void saveFile()
        {
             
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
           // Driver.driver.Quit();
        }
    }
}
