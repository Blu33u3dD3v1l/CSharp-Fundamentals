using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            var someString = Console.ReadLine();
            var numToRepeat = int.Parse(Console.ReadLine());
            repeatString(someString, numToRepeat);

        }
        static void repeatString(string someString, int numToRepeat)
        {
            var a = string.Empty;
            for (int i = 0; i < numToRepeat; i++)
            {
                a += someString;
            }
            Console.WriteLine(a);
        }
    }
}