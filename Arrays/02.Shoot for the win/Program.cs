using System;
using System.Linq;
using System.Collections.Generic;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = 0;
            var shotTargets = 0;

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "End")
                {
                    break;

                }
                var num = int.Parse(line);
                if (num > arr.Length - 1)
                {
                    continue;
                }
                number = arr[num];
                arr[num] = -1;
                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] > -1 && arr[i] > number)
                    {
                        arr[i] = arr[i] - number;
                    }
                    else if (arr[i] > -1 && arr[i] <= number)
                    {
                        arr[i] = arr[i] + number;
                    }

                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                {
                    shotTargets++;
                }
            }
            Console.WriteLine($"Shot targets: { shotTargets} -> {string.Join(" ", arr)}");
        }
    }
}
