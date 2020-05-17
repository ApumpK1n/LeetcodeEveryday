
// 560. 和为K的子数组

// 给定一个整数数组和一个整数 k，你需要找到该数组中和为 k 的连续的子数组的个数。
// 1.暴力解法

// 2.前缀和
using System.Collections.Generic;
public class Solution 
{
    public int SubarraySum(int[] nums, int k)
    {
        int count = 0, pre = 0;
        Dictionary<int, int> dict = new Dictionary<int, int> {{0, 1}};
        for (int i = 0; i < nums.Length; i++)
        {
            pre += nums[i];
            if (dict.ContainsKey(pre - k))
                count += dict[pre - k];

            if (dict.ContainsKey(pre))
            {
                dict[pre]++;
            }
            else
            {
                dict.Add(pre, 1);
            }
        }

        return count;
    }
}
