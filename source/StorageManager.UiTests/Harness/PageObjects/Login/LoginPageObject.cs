// <copyright file="LoginPageObject.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.PageObjects
{
    using OpenQA.Selenium;
    using StorageManager.UiTests.Harness;

    public class LoginPageObject
    {
        private readonly IWebDriver webDriver;
        private readonly IPageObjectFactory pageObjectFactory;

        public LoginPageObject(IWebDriver webDriver, IPageObjectFactory pageObjectFactory)
        {
            this.webDriver = webDriver;
            this.pageObjectFactory = pageObjectFactory;
        }

        public IWebElement UsernameTextBox => this.webDriver.FindElement(By.Id("emailInput"));

        public IWebElement PasswordTextBox => this.webDriver.FindElement(By.Id("passwordInput"));

        public IWebElement LoginButton => this.webDriver.FindElement(By.Id("loginButton"));

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
