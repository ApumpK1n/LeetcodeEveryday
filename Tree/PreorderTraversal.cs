

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 144. 二叉树的前序遍历

// 给定一个二叉树，返回它的 前序 遍历。

using System.Collections.Generic;

public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> lstRes = new List<int>();
        preorderTraversal(root, lstRes);
        return lstRes;
    }

    private void preorderTraversal(TreeNode node, List<int> lstRes){
        if (node == null) return;
        lstRes.Add(node.val);
        preorderTraversal(node.left, lstRes);
        preorderTraversal(node.right, lstRes);
    } 
}