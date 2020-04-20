using System;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)

        {

            do
            {
                Console.WriteLine("Enter a number");
                number = Console.ReadLine();
                var num = int.Parse(number);

                for (int i = 0; i <= num; i++)
               {
                 Console.WriteLine(i);
               }
                Console.WriteLine("Would you like to continue? y/n");
                response = Console.ReadLine();
            } while (response == "y");

            Console.WriteLine("Goodbye!");

         
       
        }
    }
}

