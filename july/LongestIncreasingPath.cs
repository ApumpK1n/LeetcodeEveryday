
// 329. 矩阵中的最长递增路径

/*
给定一个整数矩阵，找出最长递增路径的长度。

对于每个单元格，你可以往上，下，左，右四个方向移动。 你不能在对角线方向上移动或移动到边界外（即不允许环绕）。
*/

// 深度优先遍历即可，每次对未遍历过的节点做上下左右深度遍历，找出比他小的数路径长度的最大值+1

public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        if(matrix.Length == 0) return 0;
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[,] visited = new int[m,n];
        int max = 0;
        for(int i=0; i<m; i++){
            for(int j=0; j<n; j++){
                if (visited[i, j] == 0){
                    max = Math.Max(max, longestIncreasingPath(matrix, i, j, visited));
                }
            }
        }
        return max;
    }

    private int longestIncreasingPath(int[][] matrix, int i, int j, int[,] visited){
        if (i < 0 || i>=matrix.Length || j<0 || j>matrix[0].Length){
            return 0;
        }
        if (visited[i, j] > 0){
            return visited[i, j];
        }
        int max = 0;
        //上
        if(i-1 > 0 && matrix[i-1][j] < matrix[i][j]){
            max = Math.Max(max, longestIncreasingPath(matrix, i-1, j, visited));
        }
        // 下
        if (i+1 <matrix.Length && matrix[i+1][j] < matrix[i][j]){
            max = Math.Max(max, longestIncreasingPath(matrix, i+1, j, visited));
        }
        // 左
        if (j-1 >0 && matrix[i][j-1] < matrix[i][j]){
            max = Math.Max(max, longestIncreasingPath(matrix, i, j-1, visited));
        }
        // 右
        if (j+1 < matrix[0].Length && matrix[i][j+1] < matrix[i][j]){
            max = Math.Max(max, longestIncreasingPath(matrix, i, j+1, visited));
        }

        visited[i, j] = max + 1;
        return max + 1;
    }
}