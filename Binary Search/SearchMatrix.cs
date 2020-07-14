
// 240. 搜索二维矩阵 II
/*
编写一个高效的算法来搜索 m x n 矩阵 matrix 中的一个目标值 target。该矩阵具有以下特性：

每行的元素从左到右升序排列。
每列的元素从上到下升序排列。

*/

// 每行开始使用二分搜索

public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int row = matrix.GetLength(0);
        
        int col = matrix.GetLength(1);
        if (row == 0 || col == 0) return false;
        for(int i=0; i<row; i++){
            if (matrix[i, 0] > target || matrix[i, col-1] < target){
                continue;
            }
            int left = 0;
            int right = col - 1;
            while(left < right){
                int mid = left + (right - left) / 2;
                if (matrix[i, mid] < target){
                    left = mid + 1;
                }
                else{
                    right = mid;
                }
            }
            if (matrix[i, left] == target){
                return true;
            }
        }
        return false;
    }

}