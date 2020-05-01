using Autofac;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StorageManager.UiTests.Harness;

namespace StorageManager.UiTests
{
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
                Url = "http:\\\\localhost:4200\\login"
            };

            builder
                .RegisterInstance(webDriver)
                .As<IWebDriver>()
                .SingleInstance();
        }
    }
}
