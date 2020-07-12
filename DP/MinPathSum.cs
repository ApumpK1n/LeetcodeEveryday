
// 64. 最小路径和

/*
给定一个包含非负整数的 m x n 网格，请找出一条从左上角到右下角的路径，使得路径上的数字总和为最小。
说明：每次只能向下或者向右移动一步。
*/

// 动归问题
//设dp[i][j] 为i,j位置的最小路径和
//有两种移动方式：
//状态转移 dp[i][j] = Min(dp[i][j-1], dp[i-1][j]) + nums[i][j]

public class Solution {
    public int MinPathSum(int[][] grid) {
        int row = grid.Length;
        if (row == 0) return 0;
        int col = grid[0].Length;
        int[,] dp = new int[row, col];
        dp[0, 0] = grid[0][0];
        for(int i=1; i<row; i++){
            dp[i, 0] = dp[i-1, 0] + grid[i][0];
        }
        for(int j=1; j<col; j++){
            dp[0, j] = dp[0, j-1] + grid[0][j];
        }
        for(int x=1; x<row; x++){
            for(int y=1; y<col; y++){
                dp[x, y] = Math.Min(dp[x, y-1], dp[x-1, y]) + grid[x][y];
            }
        }
        return dp[row-1, col-1];
    }
}