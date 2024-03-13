using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_DelegateFunc
{
    internal class EmployeeDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public void PromotedEmployee(EmployeeDemo[] employees, Func<EmployeeDemo,bool>func)
        {
            foreach (EmployeeDemo employee in employees)
            {

                if (func(employee))
                {

                    Console.WriteLine($"{employee.Id},{employee.Name} eligible for promotion");
                }
            }

        }
    }
}
