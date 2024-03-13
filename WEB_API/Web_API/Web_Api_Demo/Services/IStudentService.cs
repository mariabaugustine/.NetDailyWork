using Microsoft.AspNetCore.Mvc;
using Web_Api_Demo.Models;

namespace Web_Api_Demo.Services
{
    public interface IStudentService    
    {
        void  AddStudent(Student student);
        IEnumerable<Student> GetStudents();

        void DeleteStudent(int id);

        void UpdateStudent(int id, Student student);
        }
    }


