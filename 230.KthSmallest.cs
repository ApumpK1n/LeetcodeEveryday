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

/*
二叉搜索树具有如下性质：

结点的左子树只包含小于当前结点的数。

结点的右子树只包含大于当前结点的数。

所有左子树和右子树自身必须也是二叉搜索树。
*/

// 中序遍历
//因为是先找最深层的节点所以用栈
using System;
using System.Collections;
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        while(root != null || stack.Count() > 0)
        {
            //先不管右子树
            while(root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            k--;
            if (k == 0) return root.val;
            root = root.right; // 当前节点的右子树
        }
        return root.val;
    }
}