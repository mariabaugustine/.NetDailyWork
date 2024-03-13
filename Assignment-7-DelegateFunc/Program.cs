namespace Assignment_7_DelegateFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDemo[] employees = new EmployeeDemo[3];
            employees[0] = new EmployeeDemo { Id = 1, Name = "Blessy", Salary = 30000, Experience = 3 };
            employees[1] = new EmployeeDemo { Id = 2, Name = "Chinnu", Salary = 20000, Experience = 3 };
            employees[2] = new EmployeeDemo { Id = 3, Name = "Melna", Salary = 10000, Experience = 3 };
            EmployeeDemo employedemo = new EmployeeDemo();
            employedemo.PromotedEmployee(employees, IsPromoted);//When you pass delegate as function parameter we didnt need to use new keword
            static bool IsPromoted(EmployeeDemo employeeDemo)
            {

                if (employeeDemo.Salary > 10000)
                {
                    return true;
                }
                return false;
            }
        }
    }
}