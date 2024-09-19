using System;
using System.Collections;
public class Solution
{
    public static void Main()
    {
        Console.WriteLine(LargestNumber([12, 23, 2, 20]));
    }

    public static string LargestNumber(int[] nums)
    {
        string[] stringsNums = new string[nums.Length];

        for (int i = 0; i < nums.Length; i++) 
        {
            stringsNums[i] = nums[i].ToString();
        }
        Array.Sort(stringsNums, new ReverserClass());

        if (stringsNums[0] == "0")
            return "0";

        return string.Join("", stringsNums);
    }
    public class ReverserClass : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            //Console.WriteLine(x + " " + y + (y + x).CompareTo(x + y));
            return (y + x).CompareTo(x + y);
        }
    }
}
