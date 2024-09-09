using System;
using System.Collections.Generic;
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
            int index = 0;

            foreach (char c in str.ToLower())
            {
                if (vowels.Contains(c))
                    str = str.Remove(index, 1);
                else
                    index++;
            }
            return str;
        }

        //LineqAnswer
        //public static string Disemvowel(string str)
        //{
        //    return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        //}
    }
}
