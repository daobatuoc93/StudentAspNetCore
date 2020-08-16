using System;

namespace StudentAspNetCore.Service.Entity
{
    public class StudentSubject
    {
        //payload
        public int Id { get; set; }
        public int Score { get; set; }
        public DateTime DateExam { get; set; }
        public string Result { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}