using System;
public class Solution
{
    public static void Main()
    {
        XorQueries([1, 3, 4, 8], [[0, 1], [1, 2], [0, 3], [3, 3]]);
    }
    public static int[] XorQueries(int[] arr, int[][] queries)
    {
        // arr = [a,b,c,d,e]
        // arrXor[0] = 0
        // arrXor[1] = a
        // arrXor[2] = a ^ b
        // arrXor[3] = a ^ b ^ c
        // arrXor[4] = a ^ b ^ c ^ d
        // arrXor[5] = a ^ b ^ c ^ d ^ e
        // want get 1 to 3
        // arrXor[1] ^ arrXor[4] = ( a ) ^ ( a ^ b ^ c ^ d )  
        // a ^ a = 0 , arrXor[1] ^ arrXor[4] = b ^ c ^ d
        // want get 2 to 4
        // arrXor[2] ^ arrXor[5] = ( a ^ b ) ^ ( a ^ b ^ c ^ d ^ e )  

        int[] arrXor = new int[arr.Length + 1];

        for (int i = 1; i <= arr.Length; i++)
        {
            arrXor[i] = arrXor[i - 1] ^ arr[i - 1];
        }

        int[] answer = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {
            int startnum = queries[i][0];
            int endnum = queries[i][1];

            answer[i] = arrXor[endnum + 1] ^ arrXor[startnum];
        }

        return answer;

        //time complexity O(n)
        //less good way

        //int startnum = 0, endnum = 0;
        //int[] answer = new int[queries.Length];

        //for (int i = 0; i < queries.Length; i++)
        //{
        //    startnum = queries[i][0];
        //    endnum = queries[i][1];

        //    if(startnum == endnum)
        //    {
        //        answer[i] = arr[startnum];
        //    }
        //    else
        //    {
        //        int count = arr[startnum];
        //        int index = startnum;

        //        do
        //        {
        //            index++;
        //            count ^= arr[index];
        //        } while (index < endnum);

        //        answer[i] = count;
        //    }
        //}
        //return answer;
    }
}
