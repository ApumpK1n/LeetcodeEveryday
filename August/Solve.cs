// 130. 被围绕的区域

/*
给定一个二维的矩阵，包含 'X' 和 'O'（字母 O）。
找到所有被 'X' 围绕的区域，并将这些区域里所有的 'O' 用 'X' 填充。
*/
/*
解释:
被围绕的区间不会存在于边界上，换句话说，任何边界上的 'O' 都不会被填充为 'X'。 任何不在边界上，或不与边界上的 'O' 相连的 'O' 最终都会被填充为 'X'。如果两个元素在水平或垂直方向相邻，则称它们是“相连”的。
*/

// 深度优先遍历，题义的意思是其实是要找到与边界上'O'相连的点

using System.Collections.Generic;

public class Solution {
    public void Solve(char[][] board) 
    {
        if (board.Length == 0) return;
        int row = board.Length;
        int col = board[0].Length;
        // 先遍历所有边界为O的点
        for(int i=0; i<row; i++){
            dfs(board, i, 0, row, col);
            dfs(board, i, col-1, row, col);
        }
        for(int j=0; j<col; j++){
            dfs(board, 0, j, row, col);
            dfs(board, row - 1, j, row, col);
        }

        for(int i=0; i < row; i++)
        {
            for(int j=0; j < col; j++)
            {
                if (board[i][j] == 'O'){
                    board[i][j] = 'X';
                }
                if (board[i][j] == 'p'){
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void dfs(char[][] board, int i, int j, int row, int col)
    {
        if (i > row - 1 || j > col - 1 || i < 0 || j < 0) return;
        if (board[i][j] != 'O') return;
        board[i][j] = 'p';
        // 找到相连的点, 上下左右
        dfs(board, i - 1, j, row, col);
        dfs(board, i + 1, j, row, col);
        dfs(board, i, j - 1, row, col);
        dfs(board, i, j + 1, row, col);
    }
}