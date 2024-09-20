using System;
using System.Collections.Generic;
public static class Kata
{
    public static void Main()
    {
        Console.WriteLine(CountSmileys([";", ")", ";*", ":$", "8-D"]));
        //Console.WriteLine(CountSmileys([":"]));
    }
    public static int CountSmileys(string[] smileys)
    {
        HashSet<char> eyes = new HashSet<char>() { ':', ';' };
        HashSet<char> nose = new HashSet<char>() { '-', '~' };
        HashSet<char> smil = new HashSet<char>() { ')', 'D' };
        int count = 0;

        foreach (string smiley in smileys) 
        {
            if (smiley.Length == 2)
            {
                if (eyes.Contains(smiley[0]) && smil.Contains(smiley[1]))
                    count++;
            }
            else if (smiley.Length == 3) 
            {
                if (eyes.Contains(smiley[0]) && nose.Contains(smiley[1]) && smil.Contains(smiley[2]))
                    count++;
            }
        }
        return count;
    }
}
