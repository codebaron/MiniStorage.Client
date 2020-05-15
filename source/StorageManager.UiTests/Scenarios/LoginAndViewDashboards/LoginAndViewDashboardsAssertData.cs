// <copyright file="LoginAndViewDashboardsAssertData.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Scenarios.LoginAndViewDashboards
{
    using StorageManager.UiTests.Scenarios.LoginAndViewDashboards.AssertionFactories;

    public static class LoginAndViewDashboardsAssertData
    {
        public static MainDashboardIsDisplayedAssertionFactory MainDashboardIsDisplayed => new MainDashboardIsDisplayedAssertionFactory();

        public static RentalsDashboardIsDisplayedAssertionFactory RentalsDashboardIsDisplayed => new RentalsDashboardIsDisplayedAssertionFactory();

        public static CustomersDashboardIsDisplayedAssertionFactory CustomersDashboardIsDisplayed => new CustomersDashboardIsDisplayedAssertionFactory();

        public static StoreDashboardIsDisplayedAssertionFactory StoreDashboardIsDisplayed => new StoreDashboardIsDisplayedAssertionFactory();

        public static AdminDashboardIsDisplayedAssertionFactory AdminDashboardIsDisplayed => new AdminDashboardIsDisplayedAssertionFactory();
    }
}
