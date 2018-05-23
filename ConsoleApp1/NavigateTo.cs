using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutotestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughtTheMenuFirefox(IWebDriver driver)
        {
            string url = Config.HomePage;
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.Id("menu-item-58")).Click();
            string LogingFormCssSelector = "article.mh-loop-item:nth-child(2) " +
                                           "> div:nth-child(2) > header:nth-child(1) " +
                                           "> h3:nth-child(1) > a:nth-child(1)";
            driver.FindElement(By.CssSelector(LogingFormCssSelector)).Click();
        }
        public static void LoginFormThroughtThePost()
        {
        }
    }
}
