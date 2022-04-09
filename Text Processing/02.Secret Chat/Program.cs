using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            while (true)
            {
                var text = Console.ReadLine();
                if (text == "Reveal")
                {
                    break;
                }
                var tokens = text.Split(":|:");

                if (tokens[0] == "InsertSpace")
                {

                    line = line.Insert(int.Parse(tokens[1]), " ");
                    Console.WriteLine(line);

                }
                if (tokens[0] == "Reverse")
                {
                    var newWord = string.Empty;
                    if (line.Contains(tokens[1]))
                    {
                        newWord = tokens[1];
                        var a = line.IndexOf(tokens[1]);
                        line = line.Remove(a, tokens[1].Length);

                    }
                    var p = newWord.ToCharArray();
                    var b = string.Empty;
                    for (int i = p.Length - 1; i >= 0; i--)
                    {
                        b += p[i];
                    }
                    line = line.Insert(line.Length, b);
                    if (string.IsNullOrEmpty(b))
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }

                }
                if (tokens[0] == "ChangeAll")
                {
                    if (line.Contains(tokens[1]))
                    {
                        line = line.Replace(tokens[1], tokens[2]);
                    }
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine($"You have a new text message: {line}");
        }
    }
}
