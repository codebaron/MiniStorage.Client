using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StorageManager.UiTests.PageObjects;

namespace StorageManager.UiTests.Scenarios
{
    public class BaseScenario
    {
        protected IWebDriver webDriver;
        protected LoginPageObject ui;

        [TestInitialize]
        public void RunBeforeTest()
        {
            this.webDriver = new ChromeDriver
            {
                Url = "http:\\\\localhost:4200\\login"
            };

            this.ui = new LoginPageObject(this.webDriver);
        }

        [TestCleanup]
        public void RunAfterTest()
        {
            this.webDriver.Quit();
        }
    }
}
