// 按摩师
//两种选择
//动态规划 a[i+1] = max(a[i], a[i-1] + nums[i])
//初始状态 a[1]=max(nums[1], nums[0]), a[0] = nums[0]

public class Solution {
    public int Massage(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        int Num = nums.Length;
        int[] dp = new int[Num];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[1], nums[0]);
        for (int i=2; i<nums.Length; i++){
            dp[i] = Math.Max(dp[i-1], dp[i-2] + nums[i]);
        }
        return dp[Num-1];
    }
}