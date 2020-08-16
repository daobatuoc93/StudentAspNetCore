using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public byte[] CurriculumVitae { get; set; }
        public int StudentId { get; set; }
        //public int SchoolId { get; set; }
        public Student Student { get; set; }
        //public School School { get; set; }
    }
}
