using System;

namespace BasicCorePrograms
{/// <summary>
/// UC8-Program to Check Whether a Number is Even or Odd 
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Taking input from user
            Console.WriteLine("Enter Number");
            int num =int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The given Number is a Even number");
            }
            else
            {
                Console.WriteLine("The given Number is a Odd Number");
            }
            Console.ReadLine();
        }
    }
}
