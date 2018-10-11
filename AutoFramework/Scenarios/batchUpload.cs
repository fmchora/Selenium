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
            Console.WriteLine(excelFile.readCell(2,3));
            Console.WriteLine(excelFile.countIcelumsInRow(2));
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
