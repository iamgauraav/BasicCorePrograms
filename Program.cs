using System;

namespace BasicCorePrograms
{/// <summary>
/// UC7-Program to Swap Two Numbers 
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int temp;

            //Taking input from user
            Console.WriteLine("Enter First=");
            int first =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second=");
            int second = int.Parse(Console.ReadLine());

            //Swaping value
            temp = first;
            first = second;
            second = temp;

            Console.WriteLine("\nAfter Swipping : ");
            Console.WriteLine("\nFirst Number : " + first);
            Console.WriteLine("\nSecond Number : " + second);
            Console.ReadLine();

        }
    }
}
