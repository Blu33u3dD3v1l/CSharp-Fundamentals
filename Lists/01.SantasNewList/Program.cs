using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantasNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            var childs = new SortedDictionary<string, int>();
            var products = new Dictionary<string, int>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var tokens = line.Split("->");
                if (tokens[0] != "Remove")
                {
                    var n = int.Parse(tokens[2]);
                    if (!childs.ContainsKey(tokens[0]))
                    {

                        childs.Add(tokens[0], n);

                    }
                    else
                    {
                        childs[tokens[0]] += n;
                    }
                    if (!products.ContainsKey(tokens[1]))
                    {
                        products.Add(tokens[1], n);
                    }
                    else
                    {
                        products[tokens[1]] += n;
                    }
                }
                else
                {
                    var name = tokens[1];
                    if (childs.ContainsKey(name))
                    {
                        childs.Remove(name);
                    }
                }
            }
            Console.WriteLine("Children:");
            foreach (var item in childs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
