using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Calculation
    {
        public void Calculate()
        {
            string x;
            double result;
            string y;
            Console.WriteLine("1ci reqemi daxil edin");
            x = Console.ReadLine();
            Console.WriteLine("2ci reqemi daxil edin");
            y = Console.ReadLine();
            Console.WriteLine("Etmek istediyiniz emeli secin ---> '+' '-' '/' '*'");
            string z = Console.ReadLine();

            int x1 = Int32.Parse(x);
            int y1 = Int32.Parse(y);

            switch (z)
            {
                case "+":
                    result = x1 + y1;
                    Console.WriteLine($"Cavab: {result}");
                    break;
                case "-":
                    result = x1 - y1;
                    Console.WriteLine($"Cavab: {result}");
                    break;
                case "/":
                    result = x1 / y1;
                    Console.WriteLine($"Cavab: {result}");
                    break;
                case "*":
                    result = x1 * y1;
                    Console.WriteLine($"Cavab: {result}");
                    break;
            }
        }
    }
}
