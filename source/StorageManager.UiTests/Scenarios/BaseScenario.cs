// <copyright file="BaseScenario.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Scenarios
{
    using Autofac;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using StorageManager.UiTests.Harness;
    using StorageManager.UiTests.PageObjects;

    public class BaseScenario
    {
        private IWebDriver webDriver;
        private IContainer container;

        public LoginPageObject Ui { get; private set; }

        [TestInitialize]
        public void RunBeforeTest()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new StorageManagerUiTestRegistrar());

            this.container = builder.Build();

            this.webDriver = this.container.Resolve<IWebDriver>();

            this.Ui = new LoginPageObject(
                this.webDriver,
                this.container.Resolve<IPageObjectFactory>());
        }

        [TestCleanup]
        public void RunAfterTest()
        {
            this.webDriver.Quit();
        }
    }
}
