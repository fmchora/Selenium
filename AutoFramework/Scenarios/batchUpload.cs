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
