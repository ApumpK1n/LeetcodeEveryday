
// 96. 不同的二叉搜索树
// 给定一个整数 n，求以 1 ... n 为节点组成的二叉搜索树有多少种？

//二叉搜索树，如果左右子树不为空，则左子树元素为小于根节点的数，右子树为大于根节点的数

// dp 动态规划
// 设dp[i] 为i时的二叉搜索树总数
public class Solution {
    public int NumTrees(int n) {
        int[] dp = new int[n+1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i=2; i<=n; i++){
            for(int j=1; j<=i; j++){
                dp[i] += dp[j-1] * dp[i - j];
            }
        }
        return dp[n];
    }
}