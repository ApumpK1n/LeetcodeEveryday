
// 97. 交错字符串

// 给定三个字符串 s1, s2, s3, 验证 s3 是否是由 s1 和 s2 交错组成的。


// 动态规划
// dp[i,j]表示为s1中i位置和s2中j位置是否交错组成s3

public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int m = s1.Length;
        int n = s2.Length;
        if (s1.Length + s2.Length != s3.Length) return false;

        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;
        for(int i=0; i<=m; i++){
            for(int j=0; j<=n; j++){
                int index = i + j - 1;
                if (i>0){
                    dp[i, j] = dp[i, j] || dp[i - 1, j] && s3[index] == s1[i - 1];
                }
                if (j>0){
                    dp[i, j] = dp[i, j] || dp[i, j-1] && s3[index] == s2[j - 1];
                }
            }
        }
        return dp[m, n];
    }
}