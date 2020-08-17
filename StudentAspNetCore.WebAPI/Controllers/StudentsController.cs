using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAspNetCore.Model.Information.Students;
using StudentAspNetCore.ViewModels.Information.Student.DTOManage;

namespace StudentAspNetCore.WebAPI.Controllers
{
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IManageStudent _manageStudent;
        public StudentsController(IManageStudent manageStudent)
        {
            _manageStudent = manageStudent;
        }
        [HttpGet]
        public async Task<IActionResult> Getall()
        {
            var student = await _manageStudent.GetAllStudent();
            return Ok(student);
        }
        [HttpGet("Findid/{id}")]
        public async Task<IActionResult> GetId(int Id)
        {
            var studentId = await _manageStudent.Find(Id);
            return Ok(studentId);
        }
        [HttpDelete("DeleteStudentId/{id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var studentdelete = await _manageStudent.DeleteStudent(Id);
            return Ok(studentdelete); 
        }
        [HttpPut("Fix/{id}")]
        public async Task<IActionResult> Update(UpdateStudentManageRequest Id)
        {
            var studentId = await _manageStudent.Update(Id);
            return Ok(studentId);
        }
        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(StudentCreateRequest request)
        {
            var studentId = await _manageStudent.Create(request);
            return Ok(studentId);
        }
    }
}
