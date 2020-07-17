
// 1. 两数之和

/*
给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
*/

using System.Collections.Generic;
public class Solution {
       //方法三：一遍哈希表
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> kvs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (kvs.ContainsKey(complement) && kvs[complement] != i)
            {
                return new int[] { i, kvs[complement] };
            }
            //需要对重复值进行判断,若结果包含了重复值，则已经被上面给return了；所以此处对于重复值直接忽略
            if (!kvs.ContainsKey(nums[i]))
            {
                kvs.Add(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
    }
}