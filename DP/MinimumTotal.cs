
// 120. 三角形最小路径和

/*
给定一个三角形，找出自顶向下的最小路径和。每一步只能移动到下一行中相邻的结点上。

相邻的结点 在这里指的是 下标 与 上一层结点下标 相同或者等于 上一层结点下标 + 1 的两个结点。
*/

// 动归
// dp[i][j] 为i行j列的元素和

using System.Collections.Generic;
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int row = triangle.Count;
        int col = triangle[row-1].Count;
        int[,] dp = new int[row, col];
        dp[0,0] = triangle[0][0];
        if (row == 1) return dp[0, 0];
        int res = int.MaxValue;
        for(int i=1; i<row; i++){
            for(int j=0; j < triangle[i].Count; j++)
            {
                if (j == 0){
                    dp[i, j] = dp[i-1, j] +  triangle[i][j];
                }
                else if (j == triangle[i].Count - 1){
                    dp[i, j] = dp[i-1, j-1] + triangle[i][j];
                }
                else{
                    dp[i, j] = Math.Min(dp[i-1, j], dp[i-1, j-1]) +  triangle[i][j];
                }
                if (i == row - 1){
                    res = Math.Min(res, dp[i, j]);
                }
            }
            
        }
        return res;
    }
}