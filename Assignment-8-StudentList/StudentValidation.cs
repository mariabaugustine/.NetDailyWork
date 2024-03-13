using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_StudentList
{
    internal class StudentValidation
    {
        public void Validation(Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
            {
                throw new StudentException("Name cannot be null");
            }

            if (student.Mark<0)
            {
                throw new StudentException("Mark cannot be negative");
            }
            if (student.Age<0)
            {
                throw new StudentException("Age must be greaterthan 0");
            }  
            if (!student.Name.All(Char.IsLetter))
                {
                throw new StudentException("Name must be alphabets");

                }
            


        }
        internal class StudentException : Exception
        {
            public  StudentException(string message) : base(message)
            {
            }
        }
    }
}
