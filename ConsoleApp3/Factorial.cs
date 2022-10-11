using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Factorial
    {
        public void CalculateFactorial()
        {
            int num = 1;
            Console.WriteLine("Eded daxil edin");
            string x = Console.ReadLine();
            int x1 = Int32.Parse(x);

            if (x1 > 0)
            {
                for (int i = x1; i > 0; i--)
                {
                    num *= i;
                }
                Console.WriteLine($"Cavab: {num}");
            }
            else if (x1 == 0)
            {
                Console.WriteLine("Cavab: 1");
            }
            else
            {
                Console.WriteLine("Duzgun reqem daxil edin");
            }
        }
    }
}
