using System;
using System.Collections.Generic;

namespace CodeWar
{
    public class Kata
    {
        public static void Main()
        {
            Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5, 5, 20 }));
        }

        //ANOTHER ANSWER
        //public static int find_it(int[] seq)
        //{
        //    int found = 0;

        //    foreach (var num in seq)
        //    {
        //        found ^= num;
        //    }

        //    return found;
        //}


        public static int find_it(int[] seq)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int i in seq)
            {
                if (!map.ContainsKey(i))
                {
                    map.Add(i, 1);
                }
                else
                {
                    map[i]++;
                }
            }

            foreach (int i in map.Keys)
            {
                if (map[i] % 2 != 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
