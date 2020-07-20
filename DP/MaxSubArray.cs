// 动态规划

public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0) return 0;
        int Max = nums[0];
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        for(int i=1; i<nums.Length; i++){
            dp[i] = Math.Max(dp[i-1]+nums[i], nums[i]);
            Max = Math.Max(dp[i], Max);
        }   
        return Max;
    }
}

// 优化内存，简化为常数级。每次使用的都只是前一个的值
public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0) return 0;
        int Max = nums[0];
        int preMax = nums[0];
        for(int i=1; i<nums.Length; i++){
            preMax = Math.Max(preMax+nums[i], nums[i]);
            Max = Math.Max(preMax, Max);
        }   
        return Max;
    }
}