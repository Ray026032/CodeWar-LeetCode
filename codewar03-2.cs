using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWar
{
    public class Kata
    {
        public static void Main()
        {
            Console.WriteLine(Disemvowel("BitcION take over the world maybe who knows perhaps"));
        }

        public static string Disemvowel(string str)
        {
            HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!vowels.Contains(char.ToLower(c)))
                    result.Append(c);
            }
            return result.ToString();
        }
    }
}
