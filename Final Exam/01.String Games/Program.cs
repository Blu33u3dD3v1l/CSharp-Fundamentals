using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace StringGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Done")
                {
                    break;
                }
                var tokens = line.Split();
                if (tokens[0] == "Cut")
                {

                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    var a = string.Empty;
                    {
                        a = word.Substring(startIndex, endIndex);
                        Console.WriteLine(a);
                    }

                }
                if (tokens[0] == "Change")
                {
                    if (word.Contains(tokens[1]))
                    {
                        word = word.Replace(tokens[1], tokens[2]);

                    }
                    Console.WriteLine(word);

                }
                if (tokens[0] == "Includes")
                {
                    if (word.Contains(tokens[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                if (tokens[0] == "End")
                {
                    var index = word[word.Length - 1];
                    if (index.ToString() == tokens[1].ToString())
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                if (tokens[0] == "Uppercase")
                {

                    word = word.ToUpper();
                    Console.WriteLine(word);
                }
                if (tokens[0] == "FindIndex")
                {
                    var a = 0;
                    if (word.Contains(tokens[1]))
                    {
                        a = word.IndexOf(tokens[1]);
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }
}
