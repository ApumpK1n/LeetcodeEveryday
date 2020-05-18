// 152. 乘积最大子数组

// 给你一个整数数组 nums ，请你找出数组中乘积最大的连续子数组（该子数组中至少包含一个数字），并返回该子数组所对应的乘积。
// 典型的动归问题
// 这里数包含 正负数，所以单纯的以fi = Math.Max(fi-1 * nums[i], nums[i])是不行的。
// 所以这里维护两个dp表， 一个是前面最大值的dp表，另一个是前面最小值的dp表, max = Max(dpmax, dpmin)，用于区分负负得正的情况

using System.Collections.Generic;
using System;

public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        Dictionary<int, int> dpMax = new Dictionary<int, int>();
        Dictionary<int, int> dpMin = new Dictionary<int, int>();

        int retMax = nums[0];
        dpMax[0] = nums[0];
        dpMin[0] = nums[0];
        for(int i=1; i<nums.Length; i++){
            dpMax[i] = Math.Max(dpMax[i-1] * nums[i], Math.Max(dpMin[i-1] * nums[i], nums[i]));
            dpMin[i] = Math.Min(dpMin[i-1] * nums[i], Math.Min(dpMax[i-1] * nums[i], nums[i]));
            retMax = Math.Max(retMax, dpMax[i]);
        }
        return retMax;
    }
}

//优化内存空间
public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        int retMax = nums[0];
        int dpMax = nums[0];
        int dpMin = nums[0];
        for(int i=1; i<nums.Length; i++){
            int lastdpMax = dpMax;
            int lastdpMin = dpMin;
            dpMax = Math.Max(lastdpMax * nums[i], Math.Max(lastdpMin * nums[i], nums[i]));
            dpMin = Math.Min(lastdpMin * nums[i], Math.Min(lastdpMax * nums[i], nums[i]));
            retMax = Math.Max(retMax, dpMax);
        }
        return retMax;
    }
}
