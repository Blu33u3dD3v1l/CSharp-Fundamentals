using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(@+|#+)(?<color>[a-z]{3,})(@+|#+)[^a-z0-9]*\/+[^a-z0-9]*(?<numbers>[0-9]+)\/";

            var line = Console.ReadLine();

            var text = Regex.Matches(line, pattern);

            foreach (Match item in text)
            {
                var color = item.Groups["color"].Value;
                var numbers = int.Parse(item.Groups["numbers"].Value);

                Console.WriteLine($"You found {numbers} {color} eggs!");
            }
        }
    }
}
