using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Char_in_a_Sring
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var dict = new Dictionary<char, int>();
            {
                foreach (var item in list)
                {
                    for (int i = 0; i < item.Length; i++)

                        if (!dict.ContainsKey(item[i]))
                        {
                            dict[item[i]] = 1;
                        }
                        else
                        {
                            dict[item[i]]++;
                        }



                }
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
