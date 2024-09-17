using System;

public class Kata
{
    public static void Main()
    {
        Console.WriteLine(UncommonFromSentences("apple apple", "banana"));
    }
    public static string[] UncommonFromSentences(string s1, string s2)
    {
        string[] s1Part = s1.Split(' ');
        string[] s2Part = s2.Split(' ');

        HashSet<string> resultS1 = new HashSet<string>();
        HashSet<string> resultS2 = new HashSet<string>();
        HashSet<string> repeat = new HashSet<string>();

        for (int i = 0; i < s1Part.Length; i++) 
        {
            if (resultS1.Contains(s1Part[i]))
                resultS1.Add(s1Part[i]);
            else
                repeat.Add(s1Part[i]);
        }

        for (int i = 0; i < s2Part.Length; i++)
        {
            if (resultS2.Contains(s2Part[i]))
                resultS2.Add(s2Part[i]);
            else
                repeat.Add(s2Part[i]);
        }

        HashSet<string> result = new HashSet<string>();

        foreach (string values in resultS1) 
        {
            if (!resultS2.Contains(values))
            {
                result.Add(values);
            }
        }
        foreach (string values in resultS2)
        {
            if (!resultS1.Contains(values))
            {
                result.Add(values);
            }
        }
        foreach (string values in repeat)
        {
            if(result.Contains(values))
            {
                result.Remove(values);
            }
        }

        return result.ToArray();
    }
}
