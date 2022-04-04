using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattertn = @"[A-Z-a-z]";
            var pattern1 = @"[0-9]";
            var dict = new Dictionary<string, int>();

            var line = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                var line1 = Console.ReadLine();
                if (line1 == "end of race")
                {
                    break;
                }
                var text = Regex.Matches(line1, pattertn);
                var text1 = Regex.Matches(line1, pattern1);
                var word = string.Empty;
                var num = 0;
                foreach (Match item in text)
                {
                    word += item.Value.ToString();

                }
                foreach (Match item in text1)
                {
                    num += int.Parse(item.ToString());
                }
                for (int i = 0; i < line.Count; i++)
                {
                    if (line[i] == word)
                    {
                        if (!dict.ContainsKey(word))
                        {
                            dict.Add(word, num);
                        }
                        else
                        {
                            dict[word] += num;
                        }
                    }
                }

            }
            var a = 0;
            var sorted = dict.OrderByDescending(x => x.Value);
            foreach (var item in sorted)
            {
                a++;
                if (a > 3)
                {
                    break;
                }
                if (a == 1)
                {
                    Console.WriteLine($"{a}st place: {item.Key}");
                }
                if (a == 2)
                {
                    Console.WriteLine($"{a}nd place: {item.Key}");
                }
                if (a == 3)
                {
                    Console.WriteLine($"{a}rd place: {item.Key}");
                }


            }
        }

    }
}