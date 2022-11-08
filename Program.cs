using System;

namespace while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Grigor Abadjiev";
            string password = "123";

            Console.WriteLine("Enter password");
            string input = Console.ReadLine();

            while (input != password)
            {
                Console.WriteLine("Wrong password");
                Console.WriteLine("Enter password");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Hello {username}!");
        }   
    }
}
