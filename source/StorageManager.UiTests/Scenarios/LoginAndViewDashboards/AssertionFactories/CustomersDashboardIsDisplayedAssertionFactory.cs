// <copyright file="CustomersDashboardIsDisplayedAssertionFactory.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Scenarios.LoginAndViewDashboards.AssertionFactories
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StorageManager.UiTests.PageObjects;

    public class CustomersDashboardIsDisplayedAssertionFactory : IAssertionFactory<MainDashboardPageObject>
    {
        public List<Action> GenerateAssertions(MainDashboardPageObject pageObject) => new List<Action>
        {
            () => { Assert.IsTrue(pageObject.PageSource.Contains("CUSTOMERS DASHBOARD", StringComparison.InvariantCulture), "Customers dashboard should be displayed"); },
        };
    }
}
