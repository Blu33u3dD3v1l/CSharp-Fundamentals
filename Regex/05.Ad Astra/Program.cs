using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            var patern = @"(#|\|)(?<product>[A-Z a-z]+)\1(?<date>[0-9]{2,}(\/)[0-9]{2,}(\/)[0-9]{2,})\1(?<calories>\d+)\1";
            var text = Console.ReadLine();

            var regex = Regex.Matches(text, patern);
            var b = new List<int>();
            var sum = 0;


            foreach (Match item in regex)
            {

                var calories = item.Groups["calories"].Value;
                var a = int.Parse(calories);
                b.Add(a);


            }
            for (int i = 0; i < b.Count; i++)
            {
                sum += b[i];
            }
            var area = 0;
            area = Math.Abs(sum / 2000);
            Console.WriteLine($"You have food to last you for: {area} days!");
            foreach (Match item in regex)
            {
                var products = item.Groups["product"].Value;
                var date = item.Groups["date"].Value;
                var calories = item.Groups["calories"].Value;

                Console.WriteLine($"Item: {products}, Best before: {date}, Nutrition: {calories}");
            }

        }
    }
}