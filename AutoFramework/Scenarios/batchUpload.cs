using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoFramework
{
    class batchUpload
    {
        IAlert alert;
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver("https://www.google.com/");
        }

        [TestCase]
        public void readFile()
        {
            
        }

        [TestCase]
        public void saveFile()
        {
            
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
