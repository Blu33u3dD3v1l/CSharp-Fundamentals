using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxes = 0.0;
            var money = 0.0;
            var alee = 0.0;
            var speciale = 0.0;
            var gaga = string.Empty;
            var a = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "special" || line == "regular")
                {
                    gaga = line;
                    break;

                }

                var num = double.Parse(line);
                for (int i = 1; i <= num; i++)
                {
                    a++;
                }

                if (num < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                if (num == 0)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                taxes = taxes + (num * 0.20);
                money += num;
                var all = taxes + money;
                alee = all;
                var area = all * 0.10;
                speciale = all - area;
            }
            if (a < 2)
            {
                Console.WriteLine("Invalid order!");
                Environment.Exit(0);
            }

            if (gaga == "special")
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine("Price without taxes: {0:f2}$", money);
                Console.WriteLine("Taxes: {0:f2}$", taxes);
                Console.WriteLine("-----------");
                Console.WriteLine("Total price: {0:f2}$", speciale);
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine("Price without taxes: {0:f2}$", money);
                Console.WriteLine("Taxes: {0:f2}$", taxes);
                Console.WriteLine("-----------");
                Console.WriteLine("Total price: {0:f2}$", alee);
            }
        }
    }
}