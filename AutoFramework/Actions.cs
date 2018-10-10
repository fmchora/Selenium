namespace AutoFramework
{
    using OpenQA.Selenium.Chrome;
    using Pages;

    public static class Actions
    {
        public static void InitializeDriver(string baseUrl= null)
        {
            Driver.driver = new ChromeDriver();
            if(baseUrl == null)
                Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            else
                Driver.driver.Navigate().GoToUrl(baseUrl);

            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }
    }
}
