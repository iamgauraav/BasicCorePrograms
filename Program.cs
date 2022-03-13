using System;

namespace BasicCorePrograms
{/// <summary>
/// UC4- Harmonic number 
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Taking input from user
            Console.WriteLine("Enter a  number");

            //converting from string to int
            int num =int.Parse(Console.ReadLine());

            double sum = 0.0;

            //For loop
            for (double count = 1; count <= num; count++)    
            {
                Console.Write("1/{0} + ", count);
                sum = sum + 1 / count;
            }


            Console.WriteLine("\nThe sum of {0}  seires is {1}  " , num, sum);
            Console.ReadLine();
        }
    }
}
