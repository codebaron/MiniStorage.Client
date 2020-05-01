// <copyright file="MainDashboardPageObject.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.PageObjects
{
    using OpenQA.Selenium;
    using StorageManager.UiTests.Harness;
    using StorageManager.UiTests.Harness.PageObjects;

    public class MainDashboardPageObject : BasePageObject
    {
        public MainDashboardPageObject(IWebDriver webDriver, IPageObjectFactory pageObjectFactory)
            : base(webDriver, pageObjectFactory)
        {
        }

        public IWebElement HomeMenuLink => this.WebDriver.FindElement(By.Id("homeMenuLink"));

        public IWebElement RentalsMenuLink => this.WebDriver.FindElement(By.Id("rentalsMenuLink"));

        public IWebElement CustomersMenuLink => this.WebDriver.FindElement(By.Id("customersMenuLink"));

        public IWebElement StoreMenuLink => this.WebDriver.FindElement(By.Id("storeMenuLink"));

        public IWebElement AdminMenuLink => this.WebDriver.FindElement(By.Id("adminMenuLink"));

        public IWebElement LogoutButton => this.WebDriver.FindElement(By.Id("logoutButton"));

        public MainDashboardPageObject ClickHomeIcon()
        {
            HomeMenuLink.Click();

            return this;
        }

        public MainDashboardPageObject ClickRentalsMenu()
        {
            RentalsMenuLink.Click();

            return this;
        }

        public MainDashboardPageObject ClickCustomersMenu()
        {
            CustomersMenuLink.Click();

            return this;
        }

        public MainDashboardPageObject ClickStoreMenu()
        {
            StoreMenuLink.Click();

            return this;
        }

        public MainDashboardPageObject ClickAdminMenu()
        {
            AdminMenuLink.Click();

            return this;
        }

        public LoginPageObject ClickLogout()
        {
            LogoutButton.Click();

            return this.PageObjectFactory.Create<LoginPageObject>();
        }
    }
}
