
// 410. 分割数组的最大值
/*
给定一个非负整数数组和一个整数 m，你需要将这个数组分成 m 个非空的连续子数组。设计一个算法使得这 m 个子数组各自和的最大值最小。

注意:
数组长度 n 满足以下条件:

1 ≤ n ≤ 1000
1 ≤ m ≤ min(50, n)
*/

public class Solution {
    public int SplitArray(int[] nums, int m) {

        int n = nums.Length;
        int[,] dp = new int[n+1, m+1];

        for(int i=0; i<=n; i++){
            for(int j=0; j<=m; j++){
                dp[i, j] = int.MaxValue;
            }
        }

        int[] sub = new int[n+1]; //前缀和
        for(int i=0; i<n; i++){
            sub[i+1] = sub[i] + nums[i];
        }
        dp[0,0] = 0;
        for(int i=1; i<=n; i++){
            for(int j=1; j<=Math.Min(i, m); j++){
                for(int k=0; k<i; k++){
                    dp[i,j] = Math.Min(dp[i, j], Math.Max(dp[k, j-1], sub[i] - sub[k]));
                }
            }
        }
        return dp[n,m];
    }
}