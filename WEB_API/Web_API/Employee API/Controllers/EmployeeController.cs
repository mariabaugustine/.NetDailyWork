using Employee_API.Models;
using Employee_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService employeeService=new EmployeeService();
        public IActionResult Get()
        {
            var employees=employeeService.GetEmployees();
            if(employees.Count()==0)
            {
                return NotFound("No record Found");
            }
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Employee employee)
        {
            var employeeAdd = employeeService.AddEmployee(employee);
            return Ok(employeeAdd);
        }
    }
}
