using StudentAspNetCore.Service.Entity;
using StudentAspNetCore.Service.Further;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.ViewModels.Information.Student
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GradeLevel Year;
        public string NameSchool { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
