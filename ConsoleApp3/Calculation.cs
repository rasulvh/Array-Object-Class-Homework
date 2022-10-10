using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Calculation
    {
        public void Input()
        {
            string x;
            string y;
            Console.WriteLine("Rasul Kalkulyatora Xos Gelmisiz \n");
            Console.WriteLine("1ci reqemi daxil edin");
            x = Console.ReadLine();
            Console.WriteLine("2ci reqemi daxil edin");
            y = Console.ReadLine();
            Console.WriteLine("Etmek istediyiniz emeli secin ---> '+' '-' '/' '*'");
            string z = Console.ReadLine();

            int x1 = Int32.Parse(x);
            int y1 = Int32.Parse(y);

            Calculate(x1, y1, z);

            AgainOrNot();
        }

        public void Calculate(int x, int y, string z)
        {
            double result;

            switch (z)
            {
                case "+":
                    result = x + y;
                    Console.WriteLine($"Cavab: {result}");
                    break;
                case "-":
                    result = x - y;
                    Console.WriteLine($"Cavab: {result}");
                    break;
                case "/":
                    result = x / y;
                    Console.WriteLine($"Cavab: {result}");
                    break;
                case "*":
                    result = x * y;
                    Console.WriteLine($"Cavab: {result}");
                    break;
            }
        }

        public void AgainOrNot()
        {
            Console.WriteLine("Yeniden emeliyyat aparmaq isteyirsen? he/yox");
            string answer = Console.ReadLine();

            if (answer == "he")
            {
                Input();
            }
            else if (answer == "yox")
            {
                Console.WriteLine("Gorusenedek");
            }
            else
            {
                Console.WriteLine("Duzgun daxil edin");
                AgainOrNot();
            }
        }
    }
}
