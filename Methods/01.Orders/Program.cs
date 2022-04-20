using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var value =
                int.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                coffe(product, value);
            }
            if (product == "water")
            {
                water(product, value);
            }
            if (product == "snacks")
            {
                snacks(product, value);
            }
            if (product == "coke")
            {
                coke(product, value);
            }

        }
        static void coffe(string product, int value)
        {
            Console.WriteLine($"{(value * 1.50):f2}");
        }
        static void water(string product, int value)
        {
            Console.WriteLine($"{(value * 1.00):f2}");
        }
        static void coke(string product, int value)
        {
            Console.WriteLine($"{(value * 1.40):f2}");
        }
        static void snacks(string product, int value)
        {
            Console.WriteLine($"{(value * 2.00):f2}");
        }
    }
}
