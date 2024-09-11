using System;
using System.Reflection;

public class Solution
{
    public static void Main()
    {
        Console.WriteLine(Convert.ToString(12,2));//1100
        Console.WriteLine(Convert.ToString(6,2)); //0110
        Console.WriteLine(12 ^ 6);                //1010 

        Console.WriteLine(Convert.ToString(22,2));//10110
        Console.WriteLine(Convert.ToString(3,2)); //00011
        Console.WriteLine(22 ^ 3);                //10101


        Console.WriteLine(MitBitFlips(12, 6));//output 2
        Console.WriteLine(MitBitFlips(22, 3));//output 3
    }

    public static int MitBitFlips(int start, int goal)
    {

        int result = start ^ goal;
        string XOR = Convert.ToString(result, 2);
        int count = 0;

        foreach (char i in XOR)
        {
            if(i == '1')
                count++;
        }

        return count;
    }
}
