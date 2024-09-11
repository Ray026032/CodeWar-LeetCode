using System;
using System.Reflection;

public class Solution
{
    public static void Main()
    {
        //MissingRolls([1, 5, 6], 3, 4);
        MissingRolls([3, 1, 4, 2, 2], 4, 6);
    }

    public static int[] MissingRolls(int[] rolls, int mean, int n)
    {
        // n = 遺失的數量
        // 總擲骰子次數乘上平均值 = 總和點數
        int maxSum = (rolls.Length + n) * mean;

        //目前已有的數字總和
        int rollsSum = 0;
        foreach (int roll in rolls) 
        {
            rollsSum += roll;
        }

        //總和點數減去已知點數 = 遺失部分的總和
        int missSum = maxSum - rollsSum;
        if (missSum < n || missSum > 6 * n)
        {
            return [];
        }

        int divsum = missSum / n;
        int modsum = missSum % n;

        int[] misspart = new int[n];

        //遺失部分的總和除以遺失部分的數量算出基礎值
        for (int i = 0; i < n; i++)
        {
            misspart[i] = divsum + (i < modsum ? 1 : 0);
        }


        return misspart;
    }
}
