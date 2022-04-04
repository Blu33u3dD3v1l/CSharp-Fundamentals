using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();
            var a = string.Empty;

            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split();

                if (tokens[0] == "register")
                {
                    if (!dict.ContainsKey(tokens[1]))
                    {
                        a = tokens[2];
                        dict.Add(tokens[1], tokens[2]);
                        Console.WriteLine($"{tokens[1]} registered {tokens[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {a}");
                    }
                }
                if (tokens[0] == "unregister")
                {
                    if (!dict.ContainsKey(tokens[1]))
                    {
                        Console.WriteLine($"ERROR: user {tokens[1]} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[1]} unregistered successfully");
                        dict.Remove(tokens[1]);
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
