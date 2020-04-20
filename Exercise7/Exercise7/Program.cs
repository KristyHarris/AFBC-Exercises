using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        string response = "";
            do
            {
                Console.WriteLine("Hello World!"); 
                Console.WriteLine("Would you like to continue? (y/n)");
                response = Console.ReadLine();
            } while(response == "y");
    }
}
