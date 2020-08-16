using Microsoft.EntityFrameworkCore;
using StudentAspNetCore.Service.Entity;
using StudentAspNetCore.Service.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentAspNetCore.Service.StudentDataSeeding
{
    public static class StudentDataSeeding
    {
        public static GradeLevel FirstYear { get; private set; }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id =1,
                    FirstName = "Dao",
                    LastName = "Van Ngoc",
                    Year = FirstYear,
                    SchoolId=1,
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Nguyen",
                    LastName = "Thi Lan Anh",
                    Year = Enums.GradeLevel.SecondYear,
                    SchoolId = 2,
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Thai",
                    LastName = "Van Lung",
                    Year = Enums.GradeLevel.FourthYear,
                    SchoolId =3,
                });
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id=1,
                    StudentId = 1,
                    UserName = "daovanngoc",
                    Password = "123456awe@",                    
                },
                new Account
                {
                    Id = 2,
                    StudentId = 2,
                    UserName = "nguyenthilananh",
                    Password = "123456rewq@",
                },
                new Account
                {
                    Id = 3,
                    StudentId = 3,
                    UserName = "thaivanlung",
                    Password = "123456fwe@",
                });
            modelBuilder.Entity<Image>().HasData(
                new Image 
                {
                    Id = 1,
                    StudentId = 1,
                    Photo = File.ReadAllBytes("F:\\StudentAspNetCore\\StudentAspNetCore\\StudentAspNetCore.Service\\Images\\daovanngoc.jpg"),
                },
                new Image
                {
                    Id = 2,
                    StudentId = 2,
                    Photo = File.ReadAllBytes("F:\\StudentAspNetCore\\StudentAspNetCore\\StudentAspNetCore.Service\\Images\\nguyenthilananh.jpg"),
                },
                new Image
                {
                    Id = 3,
                    StudentId = 3,
                    Photo = File.ReadAllBytes("F:\\StudentAspNetCore\\StudentAspNetCore\\StudentAspNetCore.Service\\Images\\thaivanlung.jpg"),
                });
            modelBuilder.Entity<School>().HasData(
                new School
                {
                    Id =1,
                    NameSchool = "Cong Nghiep University"
                },
                new School
                {
                    Id = 2,
                    NameSchool = "Au Lac University"
                },
                new School
                {
                    Id = 3,
                    NameSchool = "Van Lang University"
                }
                );
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    StudentId = 1,
                    City = "Dong Hoi",
                    Email = "daovanngoc@gmail.com",                    
                },
                new Address
                {
                    Id = 2,
                    StudentId = 2,
                    City = "TPHCM",
                    Email = "nguyenthilananh@gmail.com",
                },
                new Address
                {
                    Id = 3,
                    StudentId = 3,
                    City = "Quang Nam",
                    Email = "thaivanlung@hotmail.com",
                });
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id =1,
                    StudentId =1,
                    NameSubject = "Math",
                },
                new Subject
                {
                    Id = 2,
                    StudentId = 1,
                    NameSubject = "Literature",
                },
                new Subject
                {
                    Id = 3,
                    StudentId = 1,
                    NameSubject = "Chemistry",
                    
                },
                new Subject
                {
                    Id = 4,
                    StudentId = 2,
                    NameSubject = "Math",
                    
                },
                new Subject
                {
                    Id = 5,
                    StudentId = 2,
                    NameSubject = "Literature",
                },
                new Subject
                {
                    Id = 6,
                    StudentId = 2,
                    NameSubject = "Chemistry",
                    
                },
                 new Subject
                 {
                     Id = 7,
                     StudentId = 3,
                     NameSubject = "Math",
                     
                 },
                new Subject
                {
                    Id = 8,
                    StudentId = 3,
                    NameSubject = "Literature",
                    
                },
                new Subject
                {
                    Id = 9,
                    StudentId =3,
                    NameSubject = "Chemistry",
                    
                }               
                );
            modelBuilder.Entity<StudentSubject>().HasData(
                new StudentSubject { 
                    Id = 1,
                    SubjectId =1,
                    Score = 9, DateExam = new DateTime(2020, 05, 20), Result = "Pass" 
                },
                new StudentSubject
                {
                    Id = 2,
                    SubjectId = 2,
                    Score = 9,
                    DateExam = new DateTime(2020, 05, 20),
                    Result = "Pass"
                },
                new StudentSubject
                {
                    Id = 3,
                    SubjectId = 3,
                    Score = 3,
                    DateExam = new DateTime(2020, 05, 21),
                    Result = "fail"
                },
                new StudentSubject
                {
                    Id = 4,
                    SubjectId = 4,
                    Score = 9,
                    DateExam = new DateTime(2020, 05, 22),
                    Result = "Pass"
                },
                new StudentSubject
                {
                    Id = 5,
                    SubjectId = 5,
                    Score = 2,
                    DateExam = new DateTime(2020, 05, 20),
                    Result = "fail"
                },
                new StudentSubject
                {
                    Id = 6,
                    SubjectId = 6,
                    Score = 9,
                    DateExam = new DateTime(2020, 05, 21),
                    Result = "Pass"
                },
                new StudentSubject
                {
                    Id = 7,
                    SubjectId = 7,
                    Score = 1,
                    DateExam = new DateTime(2020, 05, 22),
                    Result = "fail"
                },
                new StudentSubject
                {
                    Id = 8,
                    SubjectId = 8,
                    Score = 4,
                    DateExam = new DateTime(2020, 05, 20),
                    Result = "fail"
                },
                new StudentSubject
                {
                    Id = 9,
                    SubjectId = 9,
                    Score = 9,
                    DateExam = new DateTime(2020, 05, 20),
                    Result = "Pass"
                });
            
        }
    }
}
