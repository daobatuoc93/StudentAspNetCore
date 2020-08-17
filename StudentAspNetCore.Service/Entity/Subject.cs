using StudentAspNetCore.Service.Further;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Entity
{
    public class Subject
    {
        public int Id { get; set; }
        public string NameSubject { get; set; }
        //use payload for Student's Subjects
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public StudentSubject StudentSubject { get; set; }
    }
}
