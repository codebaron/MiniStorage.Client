// <copyright file="BasePageObject.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Harness.PageObjects
{
    using System;
    using OpenQA.Selenium;

    public class BasePageObject : IPageObject
    {
        public BasePageObject(IWebDriver webDriver, IPageObjectFactory pageObjectFactory)
        {
            this.WebDriver = webDriver;
            this.PageObjectFactory = pageObjectFactory;
        }

        public IWebDriver WebDriver { get; private set; }

        public IPageObjectFactory PageObjectFactory { get; private set; }

        public void Verify()
        {
            throw new NotImplementedException();
        }
    }
}
