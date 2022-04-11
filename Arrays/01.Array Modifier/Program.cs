using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            {
                while (true)
                {
                    var line = Console.ReadLine();
                    if (line == "end")
                    {
                        break;

                    }
                    var tokens = line.Split();

                    if (tokens[0] == "swap")
                    {
                        var a = int.Parse(tokens[1]);
                        var b = int.Parse(tokens[2]);
                        var f = list[a];
                        list[a] = list[b];
                        list[b] = f;




                    }
                    if (tokens[0] == "multiply")
                    {
                        var a = int.Parse(tokens[1]);
                        var b = int.Parse(tokens[2]);
                        var sum = 0;
                        int firstNum = list[a];
                        var secondNum = list[b];
                        sum = firstNum * secondNum;
                        list.Insert(a, sum);
                        list.RemoveAt(a + 1);



                    }
                    if (tokens[0] == "decrease")
                    {

                        for (int i = 0; i < list.Count; i++)
                        {
                            list[i] = list[i] - 1;
                        }
                    }

                }
                Console.WriteLine(string.Join(", ", list));

            }
        }
    }
}