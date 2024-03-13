using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_StudentList
{
    internal class Student
    {
       // public static List<Student> Students = new List<Student>();
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int Mark { get; set; }
       
        public void AddStudent(List<Student>Students)
        {
            Id = Students.Count == 0 ? 100 : Students.Max(student => student.Id) + 1;
            Students.Add(new Student()
            {
                Id = Id,
                Name = Name,
                Age = Age,
                Mark= Mark
            }) ;
            
           
        }
        public List<Student> ViewStudents(List<Student>Students) 
        {
           return Students;
        }
        public List<Student> TopStudent(List<Student> Students)
        {
            var highest = Students.FindAll(value => value.Mark > 60);
            return highest;
        }
        public void RemoveAll(List<Student> Students)
        {
            Students.Clear();
            Console.WriteLine("Student list is empty");
        }

         
    }
}
