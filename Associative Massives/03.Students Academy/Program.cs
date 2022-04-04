using System;
using System.Linq;
using System.Collections.Generic;

namespace studentsAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, grade);
                }
                else
                {

                    dict[name] = (dict[name] + grade) / 2;

                }


            }

            foreach (var item in dict)
            {

                if (item.Value >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value:f2}");
                }


            }
        }
    }
}
