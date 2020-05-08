// 221. 最大正方形
// 在一个由 0 和 1 组成的二维矩阵内，找到只包含 1 的最大正方形，并返回其面积。

// 动态规划
// 第i,j 个数时最大的正方形边长由 它的左上，左，上，三个边的边长最小值决定

using System;

public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int maxSide = 0;
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) {
            return maxSide;
        }
        int rows = matrix.Length, columns = matrix[0].Length;
        int [,] dp = new int[rows, columns];
        for(int i=0; i<rows; i++){
            for(int j=0; j<columns; j++){
                if (matrix[i][j] == '1'){
                    if (i == 0 || j == 0){
                        dp[i, j] = 1;
                    }
                    else{
                        dp[i, j] = Math.Min(Math.Min(dp[i-1, j], dp[i, j-1]), dp[i-1, j-1]) + 1;
                    }
                    maxSide = Math.Max(maxSide, dp[i, j]);
                }
                else{
                    dp[i, j] = 0;
                }
            }
        }
        return maxSide * maxSide;
    }
}