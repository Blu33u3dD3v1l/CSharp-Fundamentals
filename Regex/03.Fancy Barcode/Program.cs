using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace FancyBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"@{1}#+[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}@{1}#+";
            var pattern1 = "[0-9]";
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                var text = Regex.Matches(line, pattern);
                var text1 = Regex.Matches(line, pattern1);
                var word = string.Empty;
                var sum = string.Empty;
                foreach (Match item in text)
                {
                    word = item.Value;

                }
                if (line != word)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    foreach (Match item in text1)
                    {
                        sum += item.Value.ToString();
                    }
                    if (string.IsNullOrEmpty(sum))
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {sum}");
                    }
                }


            }

        }
    }
}