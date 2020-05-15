// <copyright file="PageObjectFactory.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Harness
{
    using System;
    using OpenQA.Selenium;
    using StorageManager.UiTests.Harness.PageObjects;

    public class PageObjectFactory : IPageObjectFactory
    {
        private readonly IWebDriver webDriver;

        public PageObjectFactory(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public T Create<T>()
        {
            return (T)Activator.CreateInstance(typeof(T), this.webDriver, this);
        }
    }
}
