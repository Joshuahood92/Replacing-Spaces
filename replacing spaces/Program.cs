using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace replacing_spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence, and watch the magic!");
            string input = Console.ReadLine();
            string pattern = "\\s+";
            string replacement = "%20";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
            Console.ReadLine();
        }
    }
}
