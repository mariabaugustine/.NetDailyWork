using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Palindrome
{
    internal class Palindrome
    {
        public void PalindromeCheck(string input)
        {
            int flag = 0;
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] == input[length - i - 1])
                {
                    flag = 1;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("{0} is palindrome", input);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome", input);
            }
        }
    }
}
