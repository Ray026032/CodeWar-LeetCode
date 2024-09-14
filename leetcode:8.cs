using System;
public class Kata
{
    public static void Main()
    {
        Console.WriteLine(LongestSubarray([311155, 311155, 311155, 311155, 311155, 311155, 311155, 311155, 201191, 311155, 311156]));
    }
    public static int LongestSubarray(int[] nums)
    {
        int currentcount = 0, Answer = 0;
        int maxNum = nums.Max();

        foreach (int x in nums) 
        {
            if (maxNum == x)
            {
                currentcount++;
                Answer = Math.Max(Answer, currentcount);
            }
            else
                currentcount = 0;
        }

        return Answer;
    }
}
