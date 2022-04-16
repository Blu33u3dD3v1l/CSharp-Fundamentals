using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(=|\/)(?<name>[A-Z]{1}[A-z]{2,})\1";

            var line = Console.ReadLine();
            var list = new List<string>();
            var text = Regex.Matches(line, pattern);
            var word = string.Empty;
            foreach (Match item in text)
            {
                var name = item.Groups["name"].Value;
                list.Add(name);
                word += name;

            }
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {word.Length}");


        }
    }
}