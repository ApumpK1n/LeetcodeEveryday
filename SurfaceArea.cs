// 二维坐标对应数字为有多少个正方体

public class Solution {
    public int SurfaceArea(int[][] grid) {
        int n = grid.Length;
        int surface = 0;
        for (int i=0; i<n; i++){
            for (int j=0; j<n; j++){
                //高度
                int level = grid[i][j];
                if (level > 0){
                    surface += level * 4 + 2;
                    //减去相邻表面积
                    if (i > 0) surface -= Math.Min(level, grid[i-1][j]) * 2;
                    if (j > 0) surface -= Math.Min(level, grid[i][j-1]) * 2;
                }
            }
        }
        return surface;
    }
}