
// 785. 判断二分图
using System.Collections;
public class Solution {

    public int UNCOLOR = 0;
    public int RED = 1;
    public int GREEN = 2;
    public bool bValid = true;
    private int[] color;
    public bool IsBipartite(int[][] graph) {
        
        color = new int[graph.Length];
        for(int i=0; i<graph.Length && bValid; i++)
        {
            if (color[i] == UNCOLOR){
                dfs(graph, i, RED);
            }
        }

       
        return bValid;
    }

    private void dfs(int[][] graph, int node, int colo)
    {
        color[node] = colo;
        int neiborColor = colo == RED ? GREEN : RED;
        for(int j=0; j<graph[node].Length; j++){
            int nNode = graph[node][j];
            if (color[nNode] == UNCOLOR){
                dfs(graph, nNode, neiborColor);
                if (!bValid){
                    return;
                }
            } // 相邻节点未染色
            else if (color[nNode] != neiborColor) // 相邻节点的颜色不是预期颜色
            {
                bValid = false;
                return;
            }
        }
    }

    
}