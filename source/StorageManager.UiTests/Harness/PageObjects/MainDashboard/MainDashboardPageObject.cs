using OpenQA.Selenium;
using StorageManager.UiTests.Harness;
using StorageManager.UiTests.Harness.PageObjects;

namespace StorageManager.UiTests.PageObjects
{
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
