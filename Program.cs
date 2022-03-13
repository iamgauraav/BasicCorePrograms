using System;

namespace BasicCorePrograms
{/// <summary>
/// UC10- Program to Find the Largest Among Three Numbers
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //input from user 
            Console.WriteLine("Enter First number");
            double first= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            double third = Convert.ToDouble(Console.ReadLine());

            if ((first > second) && (first > third))
            {
                Console.WriteLine("First is Largest");
            }
            else if ((second > first) && (second > third))
            {
                Console.WriteLine("Second is Largest");
            }
            else
            {
                Console.WriteLine("Third is largest");
            }
            Console.ReadLine();
        }
    }
}
