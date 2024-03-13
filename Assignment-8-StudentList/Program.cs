using System.Threading.Channels;
using static Assignment_8_StudentList.StudentValidation;

namespace Assignment_8_StudentList
{
    internal class Program
    {
        static void Main(string[] args)
        {

         List<Student> Students = new List<Student>();
         Student student = new Student();
         StudentValidation studentValidation = new StudentValidation();
         Console.WriteLine("..............Student Management..............");
         int choice=0;
         do
            {
                try
                {


                    Console.WriteLine("Enter the Choice:\n1.Add Student\n2.View All Student\n3.View All student with mark>60\n4.Remove all student\n5.Exit");
                   //int.TryParse(Console.ReadLine(), out int number);
                   //choice=number;
                   choice=Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            try
                            {

                                GetDetails();
                                studentValidation.Validation(student);
                                student.AddStudent(Students);
                                Console.WriteLine("Student added successfully");

                            }

                            catch (StudentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 2:

                            var studentList = student.ViewStudents(Students);
                            if (studentList.Count == 0)
                            {
                                Console.WriteLine("No record found");
                            }
                            else
                            {
                                foreach (Student student1 in studentList)
                                {
                                    Console.WriteLine($"StudentId:{student1.Id}\tName:{student1.Name}\tAge:{student1.Age}\tMark:{student1.Mark}");
                                }
                            }
                            break;
                        case 3:
                            var highestList = student.TopStudent(Students);
                            if (highestList.Count == 0)
                            {
                                Console.WriteLine("No record found");
                            }
                            else
                            {
                                foreach (Student student1 in highestList)
                                {
                                    Console.WriteLine($"StudentId:{student1.Id}\tName:{student1.Name}\tAge:{student1.Age}\tMark:{student1.Mark}\n");
                                }
                            }

                            break;
                        case 4:
                            student.RemoveAll(Students);
                            Console.WriteLine("Student Records deleted successfully");
                            break;
                        case 5: break;


                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);
                }



            } while (choice != 5);




            void GetDetails()
            {
                Console.WriteLine("Enter the Name:");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter the Age");
                //int.TryParse(Console.ReadLine(), out int number);
                //student.Age = number;
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the mark");
                //int.TryParse(Console.ReadLine(), out int numberOne);
                //student.Mark = numberOne;
                student.Mark = Convert.ToInt32(Console.ReadLine());
            }
        }
    }   
    
}
