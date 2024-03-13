namespace Assignment6_PresentDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
             DateTime date = DateTime.Now;
              DayOfWeek day = date.DayOfWeek;
             Console.WriteLine($"Today is {day}");
           
                
            
        }
    }
}