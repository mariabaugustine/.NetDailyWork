using Microsoft.AspNetCore.Mvc;
using Web_Api_Demo.Models;

namespace Web_Api_Demo.Services
{
    public class StudentService:IStudentService
    {
        public static List<Student> students = new List<Student>();
        
        public void AddStudent(Student student)
            {
            student.Id = students.Count == 0 ? 1 : students.Max(id => id.Id) + 1;
            students.Add(student);
           
            }
        public IEnumerable<Student> GetStudents()
        { 
            return students;
        }
        
        public void DeleteStudent(int id) 
        {
            var deleteItem = students.Find(s_id => s_id.Id ==id);
            if(deleteItem != null) 
            {
            students.Remove(deleteItem);
            }
            
                
            
        }
        public void UpdateStudent(int id,Student student)
        {
            var findItem=students.Find(s_id=>s_id.Id ==id);
            findItem.FirstName = student.FirstName;
            findItem.LastName = student.LastName;
            //findItem.Age= student.Age;
        }
        

      
    }
}
