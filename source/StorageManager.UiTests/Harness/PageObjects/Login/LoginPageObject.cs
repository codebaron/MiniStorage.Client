using OpenQA.Selenium;
using StorageManager.UiTests.Harness;

namespace StorageManager.UiTests.PageObjects
{
    public class LoginPageObject
    {
        private readonly IWebDriver webDriver;
        private readonly IPageObjectFactory pageObjectFactory;

        public IWebElement UsernameTextBox => webDriver.FindElement(By.Id("emailInput"));
        public IWebElement PasswordTextBox => webDriver.FindElement(By.Id("passwordInput"));
        public IWebElement LoginButton => webDriver.FindElement(By.Id("loginButton"));

        public LoginPageObject(IWebDriver webDriver, IPageObjectFactory pageObjectFactory)
        {
            this.webDriver = webDriver;
            this.pageObjectFactory = pageObjectFactory;
        }

        public LoginPageObject EnterUsername(string username)
        {
            this.UsernameTextBox.SendKeys(username);

            return this;
        }

        public LoginPageObject EnterPassword(string password)
        {
            this.PasswordTextBox.SendKeys(password);

            return this;
        }

        public MainDashboardPageObject ClickLogin()
        {
            this.LoginButton.Click();

            return this.pageObjectFactory.Create<MainDashboardPageObject>();
        }
    }
}
