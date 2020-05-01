// <copyright file="UserObjectMother.cs" company="Corey Baron">
// Copyright (c) Corey Baron. All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace StorageManager.UiTests.TestData.ObjectMothers
{
    using StorageManager.UiTests.TestData.Data;

    public static class UserObjectMother
    {
        public static User Codebaron => new User
            {
                Username = "codebaron",
                Password = "password",
            };
    }
}
