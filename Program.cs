using System;

namespace BasicCorePrograms
{/// <summary>
/// UC5-Find Prime Factor 
/// 
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //taking input from user
            Console.WriteLine("Enter a number");
            int num =Convert.ToInt32(Console.ReadLine());
            //local variable
            int isPrime;

            for (int count = 2; count <=num; count++)
            {
                if (num % count == 0)
                {
                    isPrime = 1;
                    //checking divisible by 2 it is not a prime number
                    for (int j = 2; j <= count/2; j++)
                    {
                        if(count % j ==0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine("Prime Factor is : " + count);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
