
// 257. 二叉树的所有路径
/*
给定一个二叉树，返回所有从根节点到叶子节点的路径。

说明: 叶子节点是指没有子节点的节点。
*/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

using System.Collections.Generic;
public class Solution {
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> res = new List<string>();
        binaryTreePaths(root, res, "");
        return res;
    }

    private void binaryTreePaths(TreeNode node, List<string> res, string now)
    {
        if (node == null)
        {
            return;
        }
        now += node.val.ToString();
        if (node.left == null && node.right == null)
        {
            res.Add(now);
            return;
        }
        now += "->";
        binaryTreePaths(node.left, res, now);
        binaryTreePaths(node.right, res, now);
    }
}