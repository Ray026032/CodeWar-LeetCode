using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static void Main()
    {
        Console.WriteLine(accum("ZpglnRxqenU"));
    }

    //Lineq
    //public static string accum(string s)
    //{
    //    // 使用 Select 遍歷字串中的每個字元，並對每個字元進行轉換
    //    return string.Join("-", s.Select((c, i) => char.ToUpper(c) + new string(char.ToLower(c), i)));

    //    // 說明:
    //    // - s.Select((c, i) => ...) 是 LINQ 的 Select 方法，遍歷字串 s 中的每個字元 c，
    //    //   並傳遞其索引 i。這讓我們可以同時獲得字元及其位置。
    //    // - char.ToUpper(c) 將當前字元 c 轉換為大寫。
    //    // - new string(char.ToLower(c), i) 創建一個字串，內容為字元 c 的小寫並重複 i 次。
    //    // - string.Join("-", ...) 將所有的結果用 "-" 連接起來。
    //}


    public static string accum(string s)
    {
        StringBuilder sb = new StringBuilder();
        int count = 0;
        foreach (char c in s)
        {
            count++;
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                    sb.Append(char.ToUpper(c));
                else
                    sb.Append(char.ToLower(c));
            }

            if (count != s.Length)
                sb.Append("-");
        }
        return sb.ToString();
    }
}
