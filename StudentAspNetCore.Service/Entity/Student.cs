using StudentAspNetCore.Service.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GradeLevel Year;
        public List<Subject> Subjects { get; set; }
        public ICollection<Image> Images { get; set; }
        public School School { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
        public int SchoolId { get; set; }
        public Account Account { get; set; }
    }
}
