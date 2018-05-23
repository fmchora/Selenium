using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutotestFramework
{
    public static class Actions
    {
        public static void Login(IWebDriver driver)
        {
            IWebElement name = driver.FindElement(By.CssSelector(".entry-content " +
                                                  "> form:nth-child(11) > ul:nth-child(1) " +
                                                  "> li:nth-child(2) > input:nth-child(1)"));
            name.SendKeys(Config.Credentials.Valid.username);

            IWebElement Password = driver.FindElement(By.CssSelector(".entry-content " +
                                                   "> form:nth-child(11) > ul:nth-child(1) " +
                                                   "> li:nth-child(4) > input:nth-child(1)"));
            Password.SendKeys(Config.Credentials.Valid.password);

            IWebElement RepeatPassword = driver.FindElement(By.CssSelector(".entry-content " +
                                                   "> form:nth-child(11) > ul:nth-child(1) " +
                                                   "> li:nth-child(6) > input:nth-child(1)"));
            RepeatPassword.SendKeys(Config.Credentials.Valid.password);


            IWebElement SubmitButon = driver.FindElement(By.CssSelector(".entry-content > form:nth-child(11) " +
                                                    "> ul:nth-child(1) > li:nth-child(7) > input:nth-child(1)"));
            SubmitButon.Click();
        }
    }
}
