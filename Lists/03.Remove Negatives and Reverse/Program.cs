using System;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                list.RemoveAll(n => n < 0);
            }
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }

            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
