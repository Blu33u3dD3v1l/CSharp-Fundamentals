using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var number = 0;
            var removed = 0;

            while (true)
            {
                var num = int.Parse(Console.ReadLine());           
              
                if(num > list.Count - 1)
                {
                    number = list[list.Count - 1];
                    removed += list[list.Count - 1];
                    var a = list[0];
                    list.RemoveAt(list.Count - 1);
                    list.Add(a);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= number)
                        {
                            list[i] += number;

                        }
                        else
                        {
                            list[i] -= number;
                        }
                    }
                    
                }
                if (num < list.Count)
                {
                    if (num < 0)
                    {

                        removed += list[0];
                        number = list[0];
                        var a = list[list.Count - 1];
                        list.RemoveAt(0);
                        list.Insert(0, a);
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] <= number)
                            {
                                list[i] += number;

                            }
                            else
                            {
                                list[i] -= number;
                            }

                        }
                    }
                    else
                    {
                        number = list[num];
                        removed += list[num];
                        list.RemoveAt(num);
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] <= number)
                            {
                                list[i] += number;

                            }
                            else
                            {
                                list[i] -= number;
                            }

                        }
                    }
                   
                    
                }             
               if(list.Count == 0)
                {
                    break;
                }
               
            }
            Console.WriteLine(removed);
          
        }
    }
}
