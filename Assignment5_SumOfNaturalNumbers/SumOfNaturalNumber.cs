using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_SumOfNaturalNumbers
{
    internal class SumOfNaturalNumber
    {
        int sum = 0;
        public void Sum(int limit)
        { 
            
            for (int i = 1; i <= limit; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Sum is:{sum}\n");
        }
    }
}
