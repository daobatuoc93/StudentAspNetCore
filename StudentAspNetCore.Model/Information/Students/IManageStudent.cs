using StudentAspNetCore.Service.Entity;
using StudentAspNetCore.ViewModels.Information.General;
using StudentAspNetCore.ViewModels.Information.Student;
using StudentAspNetCore.ViewModels.Information.Student.DTOManage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentAspNetCore.Model.Information.Students
{
    public interface IManageStudent
    {
        Task<int> Create(StudentCreateRequest request);
        Task<int> Update(UpdateStudentManageRequest request);
        Task<int> DeleteStudent(int studentId);
        Task<List<StudentViewModel>> GetAllStudent();
        Task<StudentViewModel> Find(int studentId);
    }
}
