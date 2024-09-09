using System;
using System.Collections.Generic;

namespace CodeWar
{
    public class Kata
    {
        public static void Main()
        {
            Console.WriteLine(IsPangram("The quiCk brOwn foX Jumps oVer the laZy dog"));//true
            Console.WriteLine(IsPangram("BitcION take over tHe world mAybe who kNows perhaps"));//fale
        }

        public static bool IsPangram(string str)
        {
            HashSet<char> letter = new HashSet<char>();

            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c))
                    letter.Add(c);
            }

            bool p = letter.Count == 26;

            return p;
        }
    }
}
