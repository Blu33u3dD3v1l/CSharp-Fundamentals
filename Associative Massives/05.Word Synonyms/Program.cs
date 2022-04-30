using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < num; i++)
            {
                var word = Console.ReadLine();
                var sinonim = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                }
                dict[word].Add(sinonim);

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}

