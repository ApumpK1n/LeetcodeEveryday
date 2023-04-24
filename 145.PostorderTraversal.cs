/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
// 145. 二叉树的后序遍历
// 给你一棵二叉树的根节点root ，返回其节点值的后序遍历。

using System.Collections.Generic;
using System.Collections;

public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if (root == null) return result;

        Stack<TreeNode> stack = new Stack<TreeNode>();

        TreeNode prev = null;
        while(root != null || stack.Count > 0)
        {
            while(root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            // 如果有右子树，并且没被记录过，Push
            if (root.right != null && root.right != prev) {
                stack.Push(root);
                root = root.right;
                continue;
            }
            //如果没有right，或者它已经被记录过
            result.Add(root.val);
            prev = root;
            root = null;
        }

        return result;
    }
}