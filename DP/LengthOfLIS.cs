// 300. 最长上升子序列

// 给定一个无序的整数数组，找到其中最长上升子序列的长度。

// 线性DP
/*
设Dp[i]为第i个元素最大的上升序列长度
初始值dp[0] = 1
dp[i] = max(dp[j]) + 1
*/
public class Solution {
    public int LengthOfLIS(int[] nums) {
        int Len = nums.Length;
        if (Len == 0) return 0;
        int[] dp = new int[Len];
        dp[0] = 1;
        int res = 1;
        for (int i=1; i<Len; i++){
            //前几个的最大值
            int MaxLen = 1;
            for(int j=0; j<i; j++){
                int num = dp[j];
                if (nums[i] > nums[j]){
                    num += 1;
                    MaxLen = Math.Max(MaxLen, num);
                }
                
            }
            dp[i] = MaxLen;
            res = Math.Max(res, dp[i]);
        }
        return res;
    }
}