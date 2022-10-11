using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Account
    {
        public void Login()
        {
            Console.WriteLine("Username");
            string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();

            if (username == "cavid123" && password == "Cavid1993")
            {
                Console.WriteLine("Giris ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir");
            }
        }
    }
}
