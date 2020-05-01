// <copyright file="LoginAndViewDashboardsScenario.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Scenarios.LoginAndViewDashboards
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using input = LoginAndViewDashboardsInputData;

    [TestClass]
    public class LoginAndViewDashboardsScenario : BaseScenario
    {
        [TestMethod]
        public void CanLoginAndViewDashboards()
        {
            Ui.EnterUsername(input.Codebaron.Username)
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
