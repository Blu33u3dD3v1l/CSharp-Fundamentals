using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace ConsoleApp96
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();


            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Decode")
                {
                    break;
                }
                var tokens = line.Split("|");
                if (tokens[0] == "Move")
                {
                    var num = int.Parse(tokens[1]);

                    for (int i = 0; i < num; i++)
                    {
                        word = word + word[i];

                    }
                    word = word.Remove(0, num);


                }
                if (tokens[0] == "Insert")
                {

                    var num = int.Parse(tokens[1]);
                    if (num >= 0 && num <= word.Length)
                    {
                        word = word.Insert(num, tokens[2]);
                    }


                }
                if (tokens[0] == "ChangeAll")
                {
                    while (word.Contains(tokens[1]))
                    {

                        word = word.Replace(tokens[1], tokens[2]);

                    }

                }
            }
            Console.WriteLine($"The decrypted message is: {word}");
        }
    }
}
