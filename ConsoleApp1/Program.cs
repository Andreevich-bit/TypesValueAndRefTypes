using System;
using Mylib;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { name = "Tom", age = 33 };
            Rename(ref p1);
            p1.Info();
            Console.ReadLine();
        }
        static void Rename(ref Person person)
        {
            person = new Person { name = "Alice", age = 22 };
        }
    }
    class Person
        {
            public string name;
            public int age;
            public void Info()
            {
                Console.WriteLine($"Name = {name}, Age = {age}");
            }
        }
    
}
