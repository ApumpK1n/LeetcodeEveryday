/*
给定一个由 0 和 1 组成的矩阵，找出每个元素到最近的 0 的距离。
两个相邻元素间的距离为 1 。*/

using System.Collections.Generic;

public class Solution {
    public int[][] UpdateMatrix(int[][] matrix) {
        Queue<int[]> queue = new Queue<int[]>();
        int row = matrix.Length;    
        int col = matrix[0].Length;
        for (int i=0; i< row; i++){
            for (int j=0; j< col; j++){
                if (matrix[i][j] == 0){ // 0入队，记录位置
                    int[] r = new int[] {i, j};
                    queue.Enqueue(r);
                }
                else{
                    matrix[i][j] = -1; // 初始化未遍历
                }
            }
        }

        int[] dx = new int[]{-1, 1, 0, 0};
        int[] dy = new int[]{0, 0, -1, 1};
        while(queue.Count > 0){
            int[] point = queue.Dequeue();
            int x = point[0];
            int y = point[1];
            for (int i=0; i < 4; i++){
                int newX = x + dx[i];
                int newY = y + dy[i];
                // 合法位置并且未遍历
                if (newX < row && newX >= 0 && newY < col && newY >= 0 && matrix[newX][newY] == -1){
                    matrix[newX][newY] = matrix[x][y] + 1;
                    queue.Enqueue(new int[] {newX, newY});
                }
            }
        }
        return matrix;
    }
}