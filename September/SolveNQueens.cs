

// 51. N 皇后
/*
n 皇后问题研究的是如何将 n 个皇后放置在 n×n 的棋盘上，并且使皇后彼此之间不能相互攻击。
上图为 8 皇后问题的一种解法。

给定一个整数 n，返回所有不同的 n 皇后问题的解决方案。

每一种解法包含一个明确的 n 皇后问题的棋子放置方案，该方案中 'Q' 和 '.' 分别代表了皇后和空位。
*/

public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        int[][] grid = new int[n][];
        for(int i = 0; i < n; i++) {
            grid[i] = new int[n];
        }
        List<int> poss = new List<int>();
        List<IList<string>> result = new List<IList<string>>();
        Calc(grid, 0, poss, () => {
            //for(int i = 0; i < poss.Count; i++) {
            //    Console.Write(poss[i]);
            //}
            //Console.WriteLine();
            result.Add(ConvertResult(poss));
        });
        return result;
    }
    // pList存放每行皇后对应的位置的int值
    public List<string> ConvertResult(List<int> pList) {
        StringBuilder sb =new StringBuilder();
        List<string> result = new List<string>();
        for(int i = 0; i < pList.Count; i++) {
            sb.Clear();
            for(int j = 0; j < pList.Count; j++) {
                if(pList[i] == j) {
                    sb.Append('Q');
                }
                else {
                    sb.Append('.');
                }
            }
            result.Add(sb.ToString());
        }
        return result;
    }
    void Calc(int[][] grid, int step, List<int> poss, Action onResult) {
        if(step >= grid.Length) {  //其中一个放置方案完成的回调
            onResult();
            return;
        }
        for(int i = 0; i < grid.Length; i++) {
            if(grid[step][i] < 1) {  //在step行查找到一个点可以放置皇后
                poss.Add(i); //在step行放置皇后到i
                for(int j = step+1; j < grid.Length; j++) {  //设置每一行不可放置的点
                    int x1 = i - (j-step);
                    int x2 = i + (j-step);
                    if(x1 >= 0) {
                        grid[j][x1] += 1;
                    }
                    if(x2 < grid.Length) {
                        grid[j][x2] += 1;
                    }
                    grid[j][i] += 1;
                }

                Calc(grid, step+1, poss, onResult);

                //恢复现场
                for(int j = step+1; j < grid.Length; j++) {
                    int x1 = i - (j-step);
                    int x2 = i + (j-step);
                    if(x1 >= 0) {
                        grid[j][x1] -= 1;
                    }
                    if(x2 < grid.Length) {
                        grid[j][x2] -= 1;
                    }
                    grid[j][i] -= 1;
                }
                poss.RemoveAt(poss.Count-1);
            }
        }
    }
}