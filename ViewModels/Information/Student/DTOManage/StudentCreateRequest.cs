using StudentAspNetCore.Service.Further;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.ViewModels.Information.Student.DTOManage
{
    public class StudentCreateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GradeLevel Year;
        public string NameSchool { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int SchoolId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
