using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StorageManager.UiTests.Harness;
using StorageManager.UiTests.PageObjects;

namespace StorageManager.UiTests.Scenarios
{
    public class BaseScenario
    {
        private IContainer container;

        protected IWebDriver webDriver;
        protected LoginPageObject ui;

        [TestInitialize]
        public void RunBeforeTest()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new StorageManagerUiTestRegistrar());

            this.container = builder.Build();

            this.webDriver = container.Resolve<IWebDriver>();

            this.ui = new LoginPageObject(
                this.webDriver,
                container.Resolve<IPageObjectFactory>());
        }

        [TestCleanup]
        public void RunAfterTest()
        {
            this.webDriver.Quit();
        }
    }
}
