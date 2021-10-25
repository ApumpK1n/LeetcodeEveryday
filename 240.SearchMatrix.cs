/*
编写一个高效的算法来搜索 m x n 矩阵 matrix 中的一个目标值 target 。该矩阵具有以下特性：

每行的元素从左到右升序排列。
每列的元素从上到下升序排列。
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        if (m == 0 || n == 0) return false;
        for(int i=0; i<m; i++)
        {
            if (matrix[i][0] > target || matrix[i][n-1] < target){
                continue;
            }
            //二分
            int left = 0;
            int right = n-1;
            while(left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (matrix[i][mid] >= target) right = mid; // =是避免left + 1导致指针移动
                else left = mid + 1;
            }// 最后left = right;

            if (matrix[i][left] == target) return true;
        }
        return false;
    }
}