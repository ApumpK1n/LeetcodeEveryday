// 机器人的运动范围
// 深度优先遍历

public class Solution {
    public int MovingCount(int m, int n, int k) {
        if (k == 0) return 0;
        int Num = 0;
        int [,] visited = new int[m,n];
        void Dfs(int i, int j){
            if (i < 0 || i >= m || j >= n || j < 0) return;
            if (i%10 + i/10 + j % 10 + j / 10 > k) return;
            if (visited[i, j] == 1) return;
            visited[i,j] = 1;
            Num += 1;
            Dfs(i+1, j);
            Dfs(i, j+1);
            Dfs(i-1, j);
            Dfs(i+1, j);
        }

        Dfs(0, 0); // 从0开始
        return Num;
    }
}