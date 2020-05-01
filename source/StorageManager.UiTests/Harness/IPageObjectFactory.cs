using StorageManager.UiTests.Harness.PageObjects;

namespace StorageManager.UiTests.Harness
{
    public interface IPageObjectFactory
    {
        T Create<T>() where T : IPageObject;
    }
}
