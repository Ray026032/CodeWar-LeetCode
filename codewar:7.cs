using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static void Main()
    {
        Console.WriteLine(MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1, 5, 7, 2, 34, 0, 0, 4, 6, 7, 0, 7, 9 }));
    }

    //BubbleSoft
    //public static int[] MoveZeroes(int[] arr)
    //{
    //    for (int i = 0; i <= arr.Length; i++)
    //        for (int j = 0; j <= arr.Length - 2; j++)
    //        {
    //            if (arr[j] == 0)
    //            {
    //                //二數交換
    //                int temp = arr[j + 1];
    //                arr[j + 1] = arr[j];
    //                arr[j] = temp;
    //            }
    //        }
    //    return arr;
    //}

    public static int[] MoveZeroes(int[] arr)
    {
        int index = 0;
        //將非零數字往前排
        for (int i = 0; i < arr.Length; i++) 
        {
            if(arr[i] != 0)
            {
                arr[index] = arr[i];
                index++;
            }    
        }
        //將零補回
        for (int i = index; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
        return arr;
    }
}
