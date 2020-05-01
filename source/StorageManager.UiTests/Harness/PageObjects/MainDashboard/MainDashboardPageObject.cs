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
        private readonly IWebDriver webDriver;
        private readonly IPageObjectFactory pageObjectFactory;

        public MainDashboardPageObject(IWebDriver webDriver, IPageObjectFactory pageObjectFactory)
        {
            this.webDriver = webDriver;
            this.pageObjectFactory = pageObjectFactory;
        }
    }
}
