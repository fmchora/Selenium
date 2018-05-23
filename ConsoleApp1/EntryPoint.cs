
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
namespace AutotestFramework
{
    [TestFixture]
    class EntryPoint
    {
        IWebDriver driver = new FirefoxDriver();

        static void Main()
        {


            //IWebElement element = driver.FindElement(By.Name(name));

            //Thread.Sleep(3000);
            //driver.Quit();

        }
  
        [SetUp]
        public void initialize()
        {
            NavigateTo.LoginFormThroughtTheMenuFirefox(driver);
        }

        [Test]
        public void ExecuTest()
        {            
            Actions.Login(driver);
            Thread.Sleep(3000);
        }

        [Test]
        public void Execut2()
        {
            driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            Menu menu = new Menu(driver);
            menu.selectors.Click();
        }

        [TearDown]
        public void cleanUp()
        {
            driver.Quit();
        }

    }
}