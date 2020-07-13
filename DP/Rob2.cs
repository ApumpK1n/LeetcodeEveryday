
// 213. 打家劫舍 II


/*
你是一个专业的小偷，计划偷窃沿街的房屋，每间房内都藏有一定的现金。这个地方所有的房屋都围成一圈，这意味着第一个房屋和最后一个房屋是紧挨着的。同时，相邻的房屋装有相互连通的防盗系统，如果两间相邻的房屋在同一晚上被小偷闯入，系统会自动报警。

给定一个代表每个房屋存放金额的非负整数数组，计算你在不触动警报装置的情况下，能够偷窃到的最高金额。
*/
// 因为形成了环，所以和之前的初始值确定就不同了，初始值有两种情况。

public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length < 2) return nums[0];
        int[] dp1 = new int[nums.Length];
        dp1[0] = 0; //不抢第一个
        dp1[1] = nums[1];
        for(int i=2; i<nums.Length; i++)
        {
            dp1[i] = Math.Max(dp1[i-2] + nums[i], dp1[i-1]);
        }

        int[] dp2 = new int[nums.Length];
        dp2[0] = nums[0];//不抢最后一个
        dp2[1] = Math.Max(nums[0], nums[1]);
        for(int j=2; j<nums.Length; j++)
        {
            dp2[j] = Math.Max(dp2[j-2] + nums[j], dp2[j-1]);
        }

        return Math.Max(dp1[nums.Length-1], dp2[nums.Length-2]);
    }
}