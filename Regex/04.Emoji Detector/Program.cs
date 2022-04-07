using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"[0-9]";
            var pattern2 = @"(::|\*{2})(?<name>[A-Z]{1}[a-z]{2,})\1";
            var line = Console.ReadLine();
            var sum = 1;
            var text = Regex.Matches(line, pattern);
            var text1 = Regex.Matches(line, pattern2);
            var startEmo = new List<string>();
            var dict = new Dictionary<string, int>();

            foreach (Match item in text)
            {
                sum *= int.Parse(item.ToString());
            }
            var a = string.Empty;

            foreach (Match item in text1)
            {
                startEmo.Add(item.Value);
                a = item.ToString();
                var sum1 = 0;
                for (int i = 2; i < a.Length - 2; i++)
                {
                    sum1 += ((byte)a[i]);
                }
                if (!dict.ContainsKey(a))
                {
                    if (sum1 > sum)
                    {
                        dict.Add(a, sum1);
                    }
                }
            }
            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{startEmo.Count} emojis found in the text. The cool ones are:");
            foreach (var item in dict)
            {

                Console.WriteLine($"{item.Key}");
            }

        }
    }
}
