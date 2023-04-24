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
// 94. 二叉树的中序遍历
// 给定一个二叉树的根节点 root ，返回它的中序遍历 。

using System.Collections;
using System.Collections.Generic;

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        
        List<int> result = new List<int>();
        if (root == null) return result;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while(root != null || stack.Count > 0)
        {
            while(root != null){
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            result.Add(root.val);
            
            //如果有右子树
            root = root.right;
        }
        return result;
    }
}