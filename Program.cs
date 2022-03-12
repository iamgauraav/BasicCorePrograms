using System;

namespace BasicCorePrograms
{/// <summary>
/// UC-2 Leap Year
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year..!!");        
            int year=int.Parse(Console.ReadLine());

            //If-else selection statement
            if((year % 4 ==0) && (year % 100 != 0) || (year % 400 ==0))     //checking for leap year 
            {
                Console.WriteLine("{0} is a leap year : " , year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year : " , year);
            }
            Console.ReadLine();
        }
    }
}
