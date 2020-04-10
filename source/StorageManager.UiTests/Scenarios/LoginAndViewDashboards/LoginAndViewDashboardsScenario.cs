using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using input = StorageManager.UiTests.Scenarios.LoginAndViewDashboards.LoginAndViewDashboardsInputData;

namespace StorageManager.UiTests.Scenarios.LoginAndViewDashboards
{
    [TestClass]
    public class LoginAndViewDashboardsScenario : BaseScenario
    {
        [TestMethod]
        public void CanLoginAndViewDashboards()
        {
            ui.EnterUsername(input.Codebaron.Username)
              .EnterPassword(input.Codebaron.Password)
              .ClickLogin();
            ////.Verify(IsMainDashboard)
            ////.ClickRentalMenu()
            ////.Verify(IsRentalsDashboard)
            ////.ClickCustomersMenu()
            ////.Verify(IsCustomersDashboard)
            ////.ClickStoreMenu()
            ////.Verify(IsStoreDashboard)
            ////.ClickAdminMenu()
            ////.Verify(IsAdminDashboard)
            ////.ClickHomeIcon()
            ////.Verify(IsMainDashboard));
        }
    }
}
