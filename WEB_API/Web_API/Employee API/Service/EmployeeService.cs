using Employee_API.Models;

namespace Employee_API.Service
{
    public class EmployeeService
    {
        static List<Employee> EmployeeList = new List<Employee>();
        public IEnumerable<Employee> AddEmployee(Employee employee)
        {
            employee.Id=EmployeeList.Count==0?0:EmployeeList.Max(x => x.Id)+1;
            EmployeeList.Add(employee);
            return EmployeeList;
        }
        public IEnumerable<Employee>GetEmployees()
        {
            return EmployeeList;
        }
    }
}
