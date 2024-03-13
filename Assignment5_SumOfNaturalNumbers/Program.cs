namespace Assignment5_SumOfNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int choice;
            do

            {
                int limit;
                Console.Write("Enter the limit:");
                limit = Convert.ToInt32(Console.ReadLine());
                SumOfNaturalNumber sumofnatural = new SumOfNaturalNumber();
                sumofnatural.Sum(limit);
                Console.WriteLine("Do you wish to continue:1 or 2");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice == 1);
        }
    }
}