// 685. 冗余连接 II

/*
在本问题中，有根树指满足以下条件的有向图。该树只有一个根节点，所有其他节点都是该根节点的后继。每一个节点只有一个父节点，除了根节点没有父节点。

输入一个有向图，该图由一个有着N个节点 (节点值不重复1, 2, ..., N) 的树及一条附加的边构成。附加的边的两个顶点包含在1到N中间，这条附加的边不属于树中已存在的边。

结果图是一个以边组成的二维数组。 每一个边 的元素是一对 [u, v]，用以表示有向图中连接顶点 u 和顶点 v 的边，其中 u 是 v 的一个父节点。

返回一条能删除的边，使得剩下的图是有N个节点的有根树。若有多个答案，返回最后出现在给定二维数组的答案。
*/

class UnionFind {
    int[] ancestor;

    public UnionFind(int n) {
        ancestor = new int[n];
        for (int i = 0; i < n; ++i) {
            ancestor[i] = i;
        }
    }

    public void Union(int index1, int index2) {
        ancestor[Find(index1)] = Find(index2);
    }

    public int Find(int index) {
        if (ancestor[index] != index) {
            ancestor[index] = Find(ancestor[index]);
        }
        return ancestor[index];
    }
}
public class Solution {
    public int[] FindRedundantDirectedConnection(int[][] edges) {
        int edgesCount=edges.Length;
        UnionFind uf=new UnionFind(edgesCount+1);
        int[] parent=new int[edgesCount+1];
        for(int i=1;i<=edgesCount;i++)
        {
            parent[i]=i;
        }
        int conflict = -1;
        int cycle = -1;
        for(int i=0;i<edgesCount;i++)
        {
            int[] edge=edges[i];
            if(parent[edge[1]]!=edge[1])
            {
                conflict=i;
            }
            else
            {
                parent[edge[1]]=edge[0];
                if(uf.Find(edge[0])==uf.Find(edge[1])){
                    cycle=i;
                }
                else{
                    uf.Union(edge[0],edge[1]);
                }
                
            }
        }
         if (conflict < 0) {
            int[] redundant = {edges[cycle][0], edges[cycle][1]};
            return redundant;
        } else {
            int[] conflictEdge = edges[conflict];
            if (cycle >= 0) {
                int[] redundant = {parent[conflictEdge[1]], conflictEdge[1]};
                return redundant;
            } else {
                int[] redundant = {conflictEdge[0], conflictEdge[1]};
                return redundant;
            }

        }
    }
}