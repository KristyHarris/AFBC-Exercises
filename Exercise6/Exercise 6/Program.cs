using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)

        {
            
            string response = "";
            do
            {
                Console.WriteLine("Hello World!"); 
                Console.WriteLine("Would you like to continue? (y/n)");
                response = Console.ReadLine();
            } while(response == "y");
           
        }
    }
}
