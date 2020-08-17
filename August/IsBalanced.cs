/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 110. 平衡二叉树

/*
给定一个二叉树，判断它是否是高度平衡的二叉树。

本题中，一棵高度平衡二叉树定义为：

一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过1。
*/

public class Solution {

    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        int num = isBalanced(root, 0);
        return num > 0;
    }

    private int isBalanced(TreeNode node, int num)
    {
        if (node == null) return num;
        num += 1;
        int left = isBalanced(node.left, num);
        int right = isBalanced(node.right, num);
        if (Math.Abs(left - right) > 1) return -1;
        return Math.Max(left, right);
    }

}