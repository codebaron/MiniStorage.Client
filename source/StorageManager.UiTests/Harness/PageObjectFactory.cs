using System;
using OpenQA.Selenium;
using StorageManager.UiTests.Harness.PageObjects;

namespace StorageManager.UiTests.Harness
{
    public class PageObjectFactory : IPageObjectFactory
    {
        private IWebDriver webDriver;

        public PageObjectFactory(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public T Create<T>() where T : IPageObject
        {
            return (T)Activator.CreateInstance(typeof(T), this.webDriver, this);
        }
    }
}
