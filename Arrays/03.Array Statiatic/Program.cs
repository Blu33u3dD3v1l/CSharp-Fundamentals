using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace array_statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().ToArray();
            while (true)
            {
                var text = Console.ReadLine();
                if(text == "END")
                {
                    break;
                }
                var tokens = text.Split();
                if(tokens[0] != "Reverse" && tokens[0] != "Replace" && tokens[0] != "Distinct")
                {
                    Console.WriteLine("Invalid input!");
                }
                if (tokens[0] == "Reverse")
                {

                    Array.Reverse(line);

                }
                if (tokens[0] == "Distinct")
                {
                    line = line.Distinct().ToArray();

                }
                if (tokens[0] == "Replace")
                {
                    var index = int.Parse(tokens[1]);
                    var word = tokens[2];
                    if (index <= line.Length - 1 && index >= 0)
                    {
                        line[index] = word;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
               
            }
 
            Console.WriteLine(string.Join(", ", line));

        }
    }
}
