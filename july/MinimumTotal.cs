

// 二维数组dp问题
// 设dp[i][j] 为i行j列路径和
//由下至上推

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int len = triangle.Count;
        int[,] dp = new int[len + 1, len + 1];

        for(int i=len-1; i>=0; i++){
            for(int j=0; j<= i; j++)
            {
                dp[i,j] = Math.Min(dp[i+1, j], dp[i+1, j+1]) + triangle[i][j];
            }
            
        }
        return dp[0,0];
    }
}