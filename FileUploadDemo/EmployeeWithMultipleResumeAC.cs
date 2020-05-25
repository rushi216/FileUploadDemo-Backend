using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadDemo
{
    public class EmployeeWithMultipleResumeAC
    {
        public string Name { get; set; }

        public List<IFormFile> Resumes { get; set; }
    }
}
