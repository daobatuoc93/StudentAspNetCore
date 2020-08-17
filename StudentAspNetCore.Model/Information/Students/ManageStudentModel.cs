using Microsoft.EntityFrameworkCore;
using StudentAspNetCore.Service.Entity;
using StudentAspNetCore.Service.EntityFrameworkDB;
using StudentAspNetCore.Service.Further;
using StudentAspNetCore.ViewModels.Information.General;
using StudentAspNetCore.ViewModels.Information.Student;
using StudentAspNetCore.ViewModels.Information.Student.DTOManage;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace StudentAspNetCore.Model.Information.Students
{
    public class ManageStudentModel : IManageStudent
    {
        private readonly StudentAspNetCoreDbContext _context;
        public ManageStudentModel(StudentAspNetCoreDbContext studentContext)
        {
            _context = studentContext;
        }
        public async Task<int> Create(StudentCreateRequest request)
        {
            var student = new Student()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                School = new School()
                {
                    NameSchool = request.NameSchool                    
                },
                Address = new Address()
                {
                    Email = request.Email,
                },
                Contact = new Contact()
                {
                    PhoneNumber = request.PhoneNumber,
                },
                Account = new Account()
                {
                    UserName = request.UserName,
                    Password = request.Password
                }                
            };
            _context.Students.Add(student);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteStudent(int Id)
        {
            var _student = await _context.Students.FindAsync(Id);
            if(_student == null)
                throw new StudentException($"The student with Id: {Id} is not existing!");
            _context.Students.Remove(_student);            
            return await _context.SaveChangesAsync(); 

        }

        public async Task<StudentViewModel> Find(int Id)
        {
            var studentId = from student in _context.Students
                               where student.Id == Id
                               select new{ student };
            if (studentId == null)
                throw new StudentException($"The student with Id: {Id} is not existing!");
            var dataquery = studentId.Select(p => new StudentViewModel()
            {
                Id = p.student.Id,
                FirstName = p.student.FirstName,
                LastName = p.student.LastName,
                Year = p.student.Year,
                Email = p.student.Address.Email,
                PhoneNumber = p.student.Contact.PhoneNumber,
                NameSchool = p.student.School.NameSchool,
            }).FirstOrDefaultAsync();
            return await dataquery;

        }

        public async Task<List<StudentViewModel>> GetAllStudent()
        {
            var query = from student in _context.Students
                        join sa in _context.Accounts on student.Id equals sa.StudentId
                        join sad in _context.Addresses on student.Id equals sad.StudentId
                        join sat in _context.Contacts on student.Id equals sat.StudentId
                        join sas in _context.Schools on student.Id equals sas.Id
                        select new { student,sa, sad, sat ,sas};
            var datarequest = query.Select(p => new StudentViewModel()
            {
                Id = p.student.Id,
                FirstName = p.student.FirstName,
                LastName = p.student.LastName,
                Year = p.student.Year,
                Email = p.sad.Email,
                PhoneNumber = p.sat.PhoneNumber,      
                NameSchool = p.sas.NameSchool,
            }).ToListAsync();
            return await datarequest;
        }

        public async Task<int> Update(UpdateStudentManageRequest request)
        {
            var student = await _context.Students.FindAsync(request.Id);            
            var studentAddress = await _context.Addresses.FirstOrDefaultAsync(id => id.StudentId == request.Id);
            var studentSchool = await _context.Schools.FirstOrDefaultAsync(id => id.Id == request.Id);
            var studentContact = await _context.Contacts.FirstOrDefaultAsync(id => id.StudentId == request.Id);
            var studentAccount = await _context.Accounts.FirstOrDefaultAsync(id => id.StudentId == request.Id);
            if (student == null)
                throw new StudentException($"The student with {request.Id} is not existing to update database! ");
            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.Address.Email = request.Email;
            student.School.NameSchool = request.NameSchool;
            student.Contact.PhoneNumber = request.PhoneNumber;
            return await _context.SaveChangesAsync();
        }        
    }
}
