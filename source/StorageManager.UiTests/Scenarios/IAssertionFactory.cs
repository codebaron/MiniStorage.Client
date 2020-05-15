// <copyright file="IAssertionFactory.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Scenarios
{
    using System;
    using System.Collections.Generic;

    public interface IAssertionFactory<TPageObject>
    {
        List<Action> GenerateAssertions(TPageObject pageObject);
    }
}
