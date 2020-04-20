// 岛屿数量
// 给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。
// 岛屿总是被水包围，并且每座岛屿只能由水平方向和/或竖直方向上相邻的陆地连接形成。

// 此外，你可以假设该网格的四条边均被水包围。
public class Solution {
    public int NumIslands(char[][] grid) {

        void dfs(int i, int j){
            grid[i][j] = '0';
            if (i - 1 > 0 && j > 0 && grid[i-1][j] == '1') dfs(i - 1, j);
            if (i + 1 < grid.Length && j > 0 && grid[i + 1][j] == '1') dfs(i + 1, j);
            if (i > 0 && j - 1 > 0 && grid[i][j - 1] == '1') dfs(i, j - 1);
            if (i > 0 && j + 1 < grid[0].Length && grid[i][j + 1] == '1') dfs(i, j + 1);
        }

        int ret = 0;
        for(int i=0; i<grid.Length; i++){
            for(int j=0; j<grid[0].Length; j++){
                if (grid[i][j] == '1'){
                    dfs(i, j);
                    ret += 1;
                }
            }
        }
        return ret;
    }
}