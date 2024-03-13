namespace Assignment4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                string input;
                Console.WriteLine("Enter the string");
                input = Console.ReadLine();
                Palindrome palindrome = new Palindrome();
                palindrome.PalindromeCheck(input);
                Console.WriteLine("Do you want to continue:");
                Console.WriteLine("Y for yes");
                Console.WriteLine("N for NO");
                choice = Console.ReadLine();
            } while (choice == "y");
        }
    }
}