// <copyright file="BasePageObject.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Harness.PageObjects
{
    using System;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using StorageManager.UiTests.Scenarios;

    public class BasePageObject<TPageObject>
        where TPageObject : BasePageObject<TPageObject>
    {
        public BasePageObject(IWebDriver webDriver, IPageObjectFactory pageObjectFactory)
        {
            this.WebDriver = webDriver;
            this.PageObjectFactory = pageObjectFactory;
        }

        public IWebDriver WebDriver { get; private set; }

        public IPageObjectFactory PageObjectFactory { get; private set; }

        public TPageObject Verify(IAssertionFactory<TPageObject> assertionFactory)
        {
            if (assertionFactory == null)
            {
                throw new ArgumentNullException(nameof(assertionFactory));
            }

            var assertions = assertionFactory.GenerateAssertions((TPageObject)this);

            Parallel.Invoke(assertions.ToArray());

            return (TPageObject)this;
        }
    }
}
