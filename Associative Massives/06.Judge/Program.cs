using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, SortedDictionary<string, int>>();
            var dict1 = new Dictionary<string, int>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "no more time")
                {
                    break;
                }
                var tokens = line.Split(" -> ");
                var name = tokens[0];
                var contest = tokens[1];
                var points = int.Parse(tokens[2]);

                if (!dict.ContainsKey(contest))
                {
                    dict[contest] = new SortedDictionary<string, int>();
                    dict[contest].Add(name, points);

                }
                else
                {


                    if (dict[contest].ContainsKey(name))
                    {
                        var p = dict[contest][name];
                        if (p < points)
                        {
                            dict[contest][name] = points;

                        }
                    }
                    else
                    {
                        dict[contest].Add(name, points);

                    }

                }
            }

            foreach (var item in dict)
            {
                int j = 0;
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");

                foreach (var a in item.Value.OrderByDescending(x => x.Value))
                {

                    if (!dict1.ContainsKey(a.Key))
                    {
                        dict1.Add(a.Key, a.Value);
                    }
                    else
                    {
                        dict1[a.Key] += a.Value;
                    }
                    j++;
                    Console.WriteLine($"{j}. {a.Key} <::> {a.Value}");

                }
            }
            Console.WriteLine("Individual standings:");
            int counter = 0;
            foreach (var item in dict1.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter++;
                Console.WriteLine($"{counter}. {item.Key} -> {item.Value}");
            }

        }
    }
}

