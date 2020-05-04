// <copyright file="IPageObjectFactory.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.Harness
{
    using StorageManager.UiTests.Harness.PageObjects;

    public interface IPageObjectFactory
    {
        T Create<T>();
    }
}
