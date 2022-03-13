using System;

namespace BasicCorePrograms
{/// <summary>
/// UC6-Program to Compute Quotient and Remainder 
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Taking input of dividend and divisior from user
            Console.WriteLine("Enter Dividend=");
            int div =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor=");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //local variable
            int rem = 0;
            int res = 0;

            res = div / divisor;
            rem = div % divisor;

            Console.WriteLine("{0} and {1} is the quotient and remainder of {2}" , +res, +rem, +div);
            Console.ReadLine();
            

        }
    }
}
