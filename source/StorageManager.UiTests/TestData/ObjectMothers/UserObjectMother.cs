using System;
using System.Collections.Generic;
using System.Text;
using StorageManager.UiTests.TestData.Data;

namespace StorageManager.UiTests.TestData.ObjectMothers
{
    public static class UserObjectMother
    {
        public static User Codebaron => new User
            {
                Username = "codebaron",
                Password = "password"
            };
    }
}
