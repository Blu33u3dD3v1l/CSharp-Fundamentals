using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchName
{
    class Program
    {
        static void Main(string[] args)
        {
            var patern = @"\+359(-| )2\1[0-9]{3,}\1[0-9]{4,4}\b";
            var text = Console.ReadLine();

            MatchCollection regex = Regex.Matches(text, patern);


            var last = regex.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", last));


        }
    }
}
