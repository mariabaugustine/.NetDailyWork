using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using Web_Api_Demo.Models;
using Web_Api_Demo.Services;

namespace Web_Api_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService studentService=new StudentService();
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Get()
        {
            var students= _studentService.GetStudents();
            if (students.Count() == 0)
            {
                return NotFound("No record Found");

            }
            return Ok(students);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
             studentService.AddStudent(student);

             

            return Ok("Added successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        { 
            _studentService.DeleteStudent(id);

            return Ok("Delete successfully");
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Student student)
        {
            _studentService.UpdateStudent(id,student);
            return Ok("Updated Successfully");

        }
    }
}
