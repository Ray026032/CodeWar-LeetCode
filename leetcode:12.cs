using System;
public class Solution
{
    public static void Main()
    {

        Console.WriteLine(CountPairs("elee"));
        //Console.WriteLine(CountPairs("eleetminicoworoep"));
        //Console.WriteLine(CountPairs("elall"));
        //Console.WriteLine(CountPairs("aabbeecciioouua"));
        //Console.WriteLine(CountPairs("ggggqq"));
    }

    public static int CountPairs(string s)
    {
        // 用來追蹤母音的出現次數為奇數或偶數
        int state = 0;
        // 用字典記錄每個狀態第一次出現的位置。
        // 00000 (0) = 全部母音出現次數都為偶數，0是Key,Value為第一次出現的位置。
        // 00001 (1) = a出現過奇數次
        // 00011 (3) = a、e出現過奇數次
        // 00111 (7) = a、e、i出現過奇數次
        // 10011 (19) = a、e、u出現過奇數次
        // 當前狀態(state)如果已經出現過:之後出現的都是非母音、有母音但是出現過偶數次
        Dictionary<int, int> stateIndex = new Dictionary<int, int>();
        //假設第一個字元不是母音,迴圈由0開始(i = 0), 0-(-1) = (i - stateIndexMap[state]) = 1。
        stateIndex[0] = -1;
        int maxLength = 0;

        // 遍歷字串
        for (int i = 0; i < s.Length; i++)
        {
            // 根據母音更新狀態
            if (s[i] == 'a')
                state ^= 1 << 0;
            else if (s[i] == 'e')
                state ^= 1 << 1;
            else if (s[i] == 'i')
                state ^= 1 << 2;
            else if (s[i] == 'o')
                state ^= 1 << 3;
            else if (s[i] == 'u')
                state ^= 1 << 4;

            // 如果當前狀態之前已經出現過，計算當前字串的長度
            if (stateIndex.ContainsKey(state))
            {
                maxLength = Math.Max(maxLength, i - stateIndex[state]);
            }
            // 如果是新狀態，記錄下該狀態第一次出現的位置
            else
            {
                stateIndex[state] = i;
            }
        }

        return maxLength;
    }
}
