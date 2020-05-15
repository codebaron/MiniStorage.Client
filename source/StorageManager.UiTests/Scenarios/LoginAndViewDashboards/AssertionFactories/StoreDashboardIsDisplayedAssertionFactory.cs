// <copyright file="StoreDashboardIsDisplayedAssertionFactory.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Scenarios.LoginAndViewDashboards.AssertionFactories
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StorageManager.UiTests.PageObjects;

    public class StoreDashboardIsDisplayedAssertionFactory : IAssertionFactory<MainDashboardPageObject>
    {
        public List<Action> GenerateAssertions(MainDashboardPageObject pageObject) => new List<Action>
        {
            () => { Assert.IsTrue(pageObject.PageSource.Contains("STORE DASHBOARD", StringComparison.InvariantCulture), "Store dashboard should be displayed"); },
        };
    }
}
