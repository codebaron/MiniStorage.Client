// <copyright file="StorageManagerUiTestRegistrar.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests
{
    using Autofac;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using StorageManager.UiTests.Harness;

    public class StorageManagerUiTestRegistrar : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<PageObjectFactory>()
                .As<IPageObjectFactory>()
                .InstancePerDependency();

            RegisterWebDriver(builder);
        }

        private static void RegisterWebDriver(ContainerBuilder builder)
        {
            var webDriver = new ChromeDriver
            {
                Url = "http:\\\\localhost:4200\\login",
            };

            builder
                .RegisterInstance(webDriver)
                .As<IWebDriver>()
                .SingleInstance();
        }
    }
}
