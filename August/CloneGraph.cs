
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;
    
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
    
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

// 133. 克隆图
/*
给你无向 连通 图中一个节点的引用，请你返回该图的 深拷贝（克隆）。

图中的每个节点都包含它的值 val（int） 和其邻居的列表（list[Node]）。

class Node {
    public int val;
    public List<Node> neighbors;
}
*/

// 遍历图即可

using System.Collections.Generic;

public class Solution {
    public Node CloneGraph(Node node) {
        
        Dictionary<Node, Node> Nodes = new Dictionary<Node, Node>();
        return dfs(node, Nodes);
    }

    private Node dfs(Node node, Dictionary<Node, Node> Nodes){
        if (node == null) return null;
        if (Nodes.ContainsKey(node)) return Nodes[node];
        Node newNode = new Node(node.val, new List<Node>());
        Nodes[node] = newNode;
        foreach(Node nei in node.neighbors){
            newNode.neighbors.Add(dfs(nei, Nodes));
        }
        return newNode;
    }
}