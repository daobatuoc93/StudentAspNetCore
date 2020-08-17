using StudentAspNetCore.ViewModels.Information.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.ViewModels.Information.Student.DTOManage
{
    public class GetStudentManagePageRequest :  PageRequest
    {
        public string keyWord { get; set; }
        public List<int> SchoolId { get; set; }
        public List<int> Id { get; set; }
    }
}
