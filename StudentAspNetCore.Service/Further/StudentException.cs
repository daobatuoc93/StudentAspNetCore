using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAspNetCore.Service.Further
{
    public class StudentException : Exception
    {
        public StudentException()
        {

        }
        public StudentException(string message)
           : base(message)
        {
        }

        public StudentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
