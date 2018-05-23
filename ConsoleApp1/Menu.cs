

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutotestFramework
{
    class Menu
    {
        public Menu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement selectors { get; set; }
    }
}
