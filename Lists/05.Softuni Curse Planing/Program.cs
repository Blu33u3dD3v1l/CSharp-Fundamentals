using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cours_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "course start")
                {
                    break;
                }
                var tokens = line.Split(":");
                var word = tokens[1] + "-Exercise";

                if (tokens[0] == "Add")
                {
                    if (!list.Contains(tokens[1]))
                    {
                        list.Add(tokens[1]);
                    }

                }
                if (tokens[0] == "Insert")
                {
                    var index = int.Parse(tokens[2]);
                    if (!list.Contains(tokens[1]))
                    {
                        list.Insert(index, tokens[1]);
                    }

                }
                if (tokens[0] == "Remove")
                {
                    if (list.Contains(tokens[1]))
                    {
                        list.Remove(tokens[1]);
                    }

                }
                if (tokens[0] == "Swap")
                {
                    var word1 = tokens[2] + "-Exercise";
                    if (list.Contains(tokens[1]) && list.Contains(tokens[2]) && list.Contains(word))
                    {

                        list.Remove(word);
                        var a = tokens[1];
                        var b = tokens[2];
                        var some = list.FindIndex(x => x == a);
                        var some1 = list.FindIndex(x => x == b);
                        list.Insert(some, b);
                        list.Remove(tokens[1]);
                        list.Insert(some1, a);
                        list.RemoveAt(some1 + 1);
                        list.Insert(some + 1, word);



                    }
                    if (list.Contains(tokens[1]) && list.Contains(tokens[2]) && list.Contains(word1))
                    {
                        list.Remove(word1);
                        var a = tokens[1];
                        var b = tokens[2];
                        var some = list.FindIndex(x => x == a);
                        var some1 = list.FindIndex(x => x == b);
                        list.Insert(some, b);
                        list.Remove(tokens[1]);
                        list.Insert(some1, a);
                        list.RemoveAt(some1 + 1);
                        list.Insert(some + 1, word1);
                    }
                    if (list.Contains(tokens[1]) && list.Contains(tokens[2]) && !list.Contains(word1) && !list.Contains(word))
                    {
                        var a = tokens[1];
                        var b = tokens[2];
                        var some = list.FindIndex(x => x == a);
                        var some1 = list.FindIndex(x => x == b);
                        list.Insert(some, b);
                        list.Remove(tokens[1]);
                        list.Insert(some1, a);
                        list.RemoveAt(some1 + 1);
                    }

                }
                if (tokens[0] == "Exercise")
                {

                    if (list.Contains(tokens[1]))
                    {
                        if (!list.Contains(word))
                        {
                            var index = list.FindIndex(x => x == tokens[1]);
                            list.Insert(index + 1, word);

                        }

                    }
                    else
                    {
                        list.Add(tokens[1]);
                        list.Add(word);
                    }


                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");

            }

        }
    }
}
