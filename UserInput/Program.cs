using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            String Firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            String Lastname = Console.ReadLine();
            Console.WriteLine("Your full name is "+ Firstname+ " "+Lastname);
            Console.WriteLine("Your full name is {0} {1}",  Firstname, Lastname);
            Console.WriteLine($"Your full name is {Firstname} {Lastname}");
        }
    }
}
