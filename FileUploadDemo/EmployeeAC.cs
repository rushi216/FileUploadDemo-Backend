using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadDemo
{
    public class EmployeeAC
    {
        public string Name { get; set; }

        public IFormFile Resume { get; set; }
    }
}
