using System;

namespace BasicCorePrograms
{/// <summary>
/// UC3- Power of 2
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Taking input from user
            Console.WriteLine("Enter a  number");

            //converting from string to int
            int value =int.Parse(Console.ReadLine()); 

            //For loop
            for (int i = 1; i < value; i++)    
            {
                //Using math.pow method() to calculate power
                //Power method(2,value) means 2 to the power value 
                var pow = Math.Pow(2,value);    
                if (0 <= value && value < 31)
                {
                    Console.WriteLine(pow);
                }
                else
                {
                    Console.WriteLine("Enter number from 1 to 31");
                }
                Console.ReadLine();
            }

         
        }
    }
}
