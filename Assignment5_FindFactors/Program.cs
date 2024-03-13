namespace Assignment5_FindFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                int number;
                Console.Write("Enter the number:");
                number = Convert.ToInt32(Console.ReadLine());
                FindFactors findFactors = new FindFactors();
                findFactors.FindFacors(number);
                Console.WriteLine("\nDo you wish to continue:1 or 2");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice == 1);
        }
    }
}