using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public partial class Account
    {
        //The ForeignKey need to have same name with property at virtual Student for Lazy loading 
        //[ForeignKey("Students")]
        public long Id { get; set; }
        public int StudentId { set; get; }
        public string _userName { get; set; }
        public string _passWord { get; set; }
        public Student Student { get; set; }
        partial void OnsettingUserName(string value);
        partial void OnsettingPassword(string value);
        public string UserName
        {
            get => _userName;
            set
            {
                OnsettingUserName(value);
                _userName = value;
            }
        }
        public string Password
        {
            get => _passWord;
            set
            {
                OnsettingPassword(value);
                _passWord = value;
            }
        }
    }
}
