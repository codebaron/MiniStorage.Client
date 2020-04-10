using OpenQA.Selenium;

namespace StorageManager.UiTests.PageObjects
{
    public class LoginPageObject
    {
        private readonly IWebDriver webDriver;

        public IWebElement UsernameTextBox => webDriver.FindElement(By.Id("emailInput"));
        public IWebElement PasswordTextBox => webDriver.FindElement(By.Id("passwordInput"));
        public IWebElement LoginButton => webDriver.FindElement(By.Id("loginButton"));

        public LoginPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
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

        public void ClickLogin()
        {
            this.LoginButton.Click();
        }
    }
}
