// 63. 不同路径 II

/*
一个机器人位于一个 m x n 网格的左上角 （起始点在下图中标记为“Start” ）。

机器人每次只能向下或者向右移动一步。机器人试图达到网格的右下角（在下图中标记为“Finish”）。

现在考虑网格中有障碍物。那么从左上角到右下角将会有多少条不同的路径？
*/

// 动态规划
// dp[i][j]表示i,j网格位置的路径数，题义可知i,j可以由上方来，或者左方来。
// 则grid[i,j] == 1, 有dp[i,j] = 0;
// grid[i, j] == 0, 有 dp[i,j] = dp[i-1,j] + dp[i, j-1]
public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int row = obstacleGrid.Length;
        if (row <= 0) return 0;
        int column = obstacleGrid[0].Length;
        int[,] dp = new int[row, column];
        for(int i=0; i<row; i++){
            if(obstacleGrid[i][0] == 1)
            {
                dp[i, 0] = 0;
                break;
            }
            else
                dp[i, 0] = 1;
        }

        for(int j=0; j<column; j++){
            if(obstacleGrid[0][j] == 1)
            {
                dp[0, j] = 0;
                break;
            }
            else
                dp[0, j] = 1;
        }
        
        for(int i=1; i<row; i++)
        {
            for(int j=1; j<column; j++)
            {
                if (obstacleGrid[i][j] == 1){
                    dp[i, j] = 0;
                }
                else
                {
                    dp[i, j] = dp[i-1, j] + dp[i, j-1];
                }
            }
        }
        return dp[row - 1, column - 1];
    }
}