// 53. 最大子序和
// 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。

//动态规划
// 两种选择
// fi = Max(n, fi-1 + n)

using System;
public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0) return 0;
        int max = nums[0];
        int fi = nums[0];
        for (int i=1; i<nums.Length; i++){
            fi = Math.Max(nums[i], fi + nums[i]);
            max = Math.Max(max, fi);
        }

        return max;
    }
}