using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var tokens = line.Split();

                if (tokens[0] == "Insert")
                {
                    var num = int.Parse(tokens[1]);
                    var num1 = int.Parse(tokens[2]);
                    list.Insert(num1, num);
                }
                if (tokens[0] == "Delete")
                {
                    var num = int.Parse(tokens[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (num == list[i])
                        {
                            list.Remove(list[i]);
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}

