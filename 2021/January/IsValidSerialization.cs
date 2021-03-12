// 331. 验证二叉树的前序序列化

public class Solution {
    int index, len;
    string[] nodes;
    public bool IsValidSerialization(string preorder) {
        nodes = preorder.Split(",".ToCharArray());
        index = 0;
        len = nodes.Length;
        return dfs() && index == len;
    }

    public bool dfs()
    {
        if(index >= len) return false;
        return nodes[index++] == "#" ? true : dfs() && dfs();
    }
}