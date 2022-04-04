using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyEmployee
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, List<string>>();
            var list = new List<string>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                var tokens = line.Split(" -> ");
                var companyName = tokens[0];
                var employee = tokens[1];

                if (!dict.ContainsKey(companyName))
                {

                    dict[companyName] = new List<string>();
                }
                if (!dict[companyName].Contains(employee))
                {
                    dict[companyName].Add(employee);
                }



            }
            foreach (var item in dict)
            {

                Console.WriteLine($"{item.Key}");
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }

            }

        }
    }
}
