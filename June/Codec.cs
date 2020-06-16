

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

/*
297. 二叉树的序列化与反序列化
使用中序遍历
*/
using System.Collections.Generic;
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        return serializeNode(root, "");
    }

    public string serializeNode(TreeNode node, string str){
        if (node == null){
            str += "null,";
        }
        else{
            str += node.val.ToString() + ",";
            str = serializeNode(node.left, str);
            str = serializeNode(node.right, str);
        }
        return str;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        string[] lstData = data.Split(",");
        List<string> datalist = lstData.ToList();
        return readdeserialize(datalist);
    }

    public TreeNode readdeserialize(List<string> l){
        if (l.Count <= 0){
            return null;
        }
        string r = l[0];
        if (r == "null"){
            l.RemoveAt(0);
            return null;
        }

        int re = 0;
        int.TryParse(r, out re);

        TreeNode root = new TreeNode(re);
        l.RemoveAt(0);
        root.left = readdeserialize(l);
        root.right = readdeserialize(l);

        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));