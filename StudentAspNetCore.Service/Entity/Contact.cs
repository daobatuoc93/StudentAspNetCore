using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public class Contact
    {
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Url { get; set; }
        public int StudentId { get; set; }
        //public int SchoolId { get; set; }
        public Student Student { get; set; }
        //public School School { get; set; }
    }
}
