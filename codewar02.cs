using System;
using System.Collections.Generic;

namespace CodeWar
{
    public class Kata
    {
        public static void Main()
        {
            Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));
        }
        public static int FindShort(string s)
        {

            string[] words = s.Split(' ');
            int max = int.MaxValue;

            foreach (string word in words)
            {
                if (word.Length < max)
                    max = word.Length;
            }
            return max;
        }
    }
}
