using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public static void Main()
    {
        Console.WriteLine(TwoSum(new int[] { 1, 2, 3, 45, 5, 4, 6, 18, 19, 6 }, 12));
    }

    //public static int[] TwoSum(int[]nums,int target)
    //{
    //    //使用迴圈
    //    for (int i = 0; i <= nums.Length; i++)
    //    {
    //        int _target = target- nums[i];
    //        for (int j = 0; j < nums.Length; j++)
    //        {
    //            if (nums[j] == _target && j != i)
    //            {
    //                return new int[] { i, j };
    //            }
    //        }
    //    }
    //    return null;
    //}

    public static int[] TwoSum(int[] nums, int target)
    {
        //使用Dictionary
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int targetNumber = target - nums[i];

            //key紀錄nums中的值、Value紀錄nums位置。為了用map[targetNumber]直接找出位置。
            if (map.ContainsKey(targetNumber))
                return new int[] { map[targetNumber], i };
            //避免重複key值
            if(!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }
        return null;
    }
}
