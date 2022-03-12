using System;

namespace BasicCorePrograms
{/// <summary>
/// UC-1 Flip Coin and print percentage of Heads and Tails
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of times Flip the coin");   
            int noFlip=int.Parse(Console.ReadLine());                   //Taking value from user

            int head = 0;
            int tail = 0;
            Random random = new Random();                               //Random class

            for (int i = 1; i < noFlip; i++)                            //for checking number of flip
            {
                int ran = random.Next(0, 2);                            //next method (0-initial,1-final)
                {
                    if (ran == 0)
                    {
                        tail++;
                    }
                    else
                    {
                        head++;
                    }

                }
            }
            Console.WriteLine("Number of times Head occurs : "+ head);
            Console.WriteLine("Number of times Tail occurs : "+ tail);
            double percentageHead = (double)head / noFlip * 100;            //percentage of head
            Console.WriteLine("Head percentage is : " + percentageHead);
            double percentageTail = (double)tail / noFlip * 100;            //percentage of tail
            Console.WriteLine("Tail percentage is : " + percentageTail);
            Console.ReadLine();
        }
    }
}
