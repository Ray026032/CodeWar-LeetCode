using System;
using System.Collections;
using System.Text;
public class Solution
{
    public static void Main()
    {
        Console.WriteLine(ShortestPalindrome("abcd"));//dcba
        Console.WriteLine(ShortestPalindrome("xzxcvb"));//bvcxzx
        Console.WriteLine(ShortestPalindrome("aacecaaa"));//aaacecaa
        //xzxcvb
    }

    public static string ShortestPalindrome(string s)
    {
        string reverseS = string.Join("", s.Reverse());

        if (CheckReverse(s))
            return s;

        StringBuilder tempReverseS = new StringBuilder();

        for (int i = 0; i < reverseS.Length; i++)
        {
            tempReverseS.Append(reverseS[i]);

            if (CheckReverse(tempReverseS + s))
                return tempReverseS.ToString() + s;
        }

        return "";

        bool CheckReverse(string s)
        {
            int index = s.Length - 1;
            for (int i = 0; index > i; i++, index--)
            {
                if (s[i] != s[index])
                    return false;
            }
            return true;
        }
    }

}

