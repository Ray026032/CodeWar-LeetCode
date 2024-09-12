using System;
using System.Linq;
using System.Reflection;

public class Solution
{
    public static void Main()
    {
        Console.WriteLine(CountConsisteneStrings("abzxc", new string[] { "ad", "bd", "aaab", "baa", "badab" }));
    }

    public static int CountConsisteneStrings(string allowed, string[] words)
    {
        HashSet<char> hashset = new HashSet<char>(allowed);

        int answerCount = 0;

        foreach (string wordString in words)
        {
            bool isConsistent = true;
            foreach (char wordChar in wordString)
            {
                if(!hashset.Contains(wordChar))
                {
                    isConsistent = false;
                    break;
                }
            }
            if (isConsistent)
                answerCount++;
        }

        return answerCount;
    }
}
