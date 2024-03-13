using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Delegate
{
    internal class EmployeeDemo
    {
       
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public void PromotedEmployee(EmployeeDemo[] employees, Predicate<EmployeeDemo> predicate)
        {
            foreach (EmployeeDemo employee in employees)
            {
                
                if (predicate(employee))
                {
                   
                    Console.WriteLine($"{employee.Id},{employee.Name} eligible for promotion");
                }
            }
        }
    }
}
