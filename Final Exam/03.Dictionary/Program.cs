using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var secondLineWords = new List<string>();
            var list = new List<string>();
            var dict = new Dictionary<string, List<string>>();
            var text = string.Empty;

            while (true)
            {
                var line = Console.ReadLine();
                text = line;
                if (line == "Test" || line == "Hand Over")
                {
                    break;
                }
                var line1 = Console.ReadLine();
                var tokens = line.Split(" | ").ToArray();
                var tokens1 = line1.Split(" | ");
                foreach (var item in tokens1)
                {
                    if (!secondLineWords.Contains(item))
                    {
                        secondLineWords.Add(item);
                    }
                }
                foreach (var item in tokens)
                {
                    var word = item.Split(": ");

                    if (!list.Contains(word[0]))
                    {
                        list.Add(word[0]);
                    }

                    if (!dict.ContainsKey(word[0]))
                    {
                        dict.Add(word[0], new List<string>() { $" -{word[1]}" });
                    }
                    else
                    {
                        dict[word[0]].Add($" -{word[1]}");
                    }
                }
            }
            if (text == "Test")
            {
                foreach (var item in dict)
                {
                    if (secondLineWords.Contains(item.Key))
                    {
                        Console.WriteLine($"{item.Key}:");
                        foreach (var a in item.Value)
                        {
                            Console.WriteLine(a);
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}