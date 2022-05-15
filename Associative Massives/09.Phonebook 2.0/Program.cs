using System;
using System.Linq;
using System.Collections.Generic;
namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var tokens = line.Split();
                if (tokens[0] == "A")
                {
                    var name = tokens[1];

                    var phoneNumber = tokens[2];
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, phoneNumber);
                    }
                    else
                    {
                        dict[name] = phoneNumber;
                    }
                }
                if (tokens[0] == "S")
                {
                    if (dict.ContainsKey(tokens[1]))
                    {

                        Console.WriteLine($"{tokens[1]} -> {dict[tokens[1]]}");

                    }
                    else
                    {
                        Console.WriteLine($"Contact {tokens[1]} does not exist.");

                    }

                }
                if(tokens[0] == "ListAll")
                {
                    foreach (var item in dict.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                        
            }
        }
    }
}

