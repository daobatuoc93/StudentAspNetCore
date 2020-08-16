using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public partial class Account
    {
        private void CheckUserPassword(string value)
        {
            var temp = value.Trim();
            if (string.IsNullOrEmpty(temp) || temp.Contains(" "))
                throw new System.Exception("Invalid Username or Password!");
        }
        partial void OnsettingPassword(string value)
        {
            CheckUserPassword(value);
        }

        partial void OnsettingUserName(string value)
        {
            CheckUserPassword(value);
        }
    }
}
