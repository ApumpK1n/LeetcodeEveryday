// 车的可用捕获量
// 车：R 空方块：. 象：B 卒:p
// 深度优先遍历, 做递归。

public class Solution {
    public int NumRookCaptures(char[][] board) {
        int Num = 0;
        void Dfs(int i, int j, int x, int y){
            if (i < 0 || i >= 8 || j >= 8 || j < 0) return;
            if (board[i][j] == 'B') return;
            if (board[i][j] == 'p') {
                Num += 1;
                return;
            }
            Dfs(i+x, j+y, x, y);
        }
        
        for (int i=0; i<8; i++){
            for (int j=0; j<8; j++){
                if (board[i][j] == 'R'){
                    Dfs(i, j+1, 0, 1); // 上
                    Dfs(i, j-1, 0, -1); // 下
                    Dfs(i-1, j, -1, 0); // 左
                    Dfs(i+1, j, 1, 0) ; //右
                }
            }
        }
        return Num;
    }
}