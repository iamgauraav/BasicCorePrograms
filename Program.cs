using System;

namespace BasicCorePrograms
{/// <summary>
/// UC9-Program to Check Whether an Alphabet is Vowel or Consonant
/// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Input an Alphabet (A-Z 0r a-z)");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The alphabate is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("The alphabate is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("The alphabate is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("The alphabate is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("The alphabate is a vowel");
                    break;
                default:
                    Console.WriteLine("The alphabate is a consonant");
                    break;
            }
            Console.ReadLine();
        }
    }
}
