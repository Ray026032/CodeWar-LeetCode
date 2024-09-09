using System;
using System.Collections.Generic;

public static class Kata
{
    public static void Main()
    {
        Console.WriteLine(Kata.GetVowelCount("o a kak ushakov lil vo kashu kakao"));
    }

    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        foreach (char c in str.ToLower())
        {
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}
