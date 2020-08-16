using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public class School
    {
        public int Id { get; set; }
        public string NameSchool { get; set; }
        public List<Student> Students { get; set; }
        //   public List<Image> Images { get; set; }
        //   public Contact Contact { get; set; }
    }
}
