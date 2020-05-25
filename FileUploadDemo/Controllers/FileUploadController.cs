using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FileUploadDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileUploadController : ControllerBase
    {
        public FileUploadController()
        {
            
        }

        /// <summary>
        /// Send single or multiple files
        /// Key name doesnt matter
        /// </summary>
        /// <returns></returns>
        [HttpPost("1")]
        public IActionResult Post()
        {
            IFormFileCollection files = Request.Form.Files;
            return Ok();
        }

        /// <summary>
        /// Send single file 
        /// Name matters
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost("2")]
        public IActionResult Post(IFormFile file)
        {   
            return Ok();
        }

        /// <summary>
        /// Send multiple files 
        /// Name matters
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost("3")]
        public IActionResult Post(List<IFormFile> files)
        {
            return Ok();
        }

        /// <summary>
        /// Send single file along with object 
        /// Model properties names matter
        /// </summary>
        /// <param name="testAC"></param>
        /// <returns></returns>
        [HttpPost("4")]
        public IActionResult Post([FromForm]EmployeeAC testAC)
        {
            return Ok();
        }

        /// <summary>
        /// Send multiple files along with object
        /// Model properties names matter
        /// </summary>
        /// <param name="testAC"></param>
        /// <returns></returns>
        [HttpPost("5")]
        public IActionResult Post([FromForm]EmployeeWithMultipleResumeAC testAC)
        {
            return Ok();
        }
    }
}
