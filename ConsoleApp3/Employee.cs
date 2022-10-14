using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Employee
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public bool isMarried;

        public Employee() : this("Rasul", "Hasanov", 15)
        {
            Console.WriteLine("Hello Student");
        }

        public Employee(int number)
        {
            Console.WriteLine(number);
        }

        public Employee(string empName, string empSurname, int empAge) : this(50)
        {
            name = empName;
            surname = empSurname;
            age = empAge;
            Console.WriteLine(name + " " + surname + " " + age);
        }

        public Employee(string empAdress) : this()
        {
            address = empAdress;
            Console.WriteLine(address);
        }

        public Employee(bool married) : this("Ehmedli")
        {
            isMarried = married;
            Console.WriteLine(isMarried);
        }

        //public string FullName()
        //{
        //    return name + " " + surname;
        //}

        //public string FullData()
        //{
        //    return $"{FullName()} {age}";
        //}

        //public void FullName()
        //{
        //    Console.WriteLine("Rasul Hasanov");
        //}
    }
}
