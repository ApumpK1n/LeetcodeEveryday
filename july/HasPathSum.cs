

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 112. 路径总和
/*
给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。
说明: 叶子节点是指没有子节点的节点。
*/

public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null) return false;
        return HasSum(root, sum, 0);
    }

    public bool HasSum(TreeNode node, int sum, int now){
        if (node == null){
            return false;
        }
        now += node.val;
        if (node.left == null && node.right == null){
            if (sum == now){
                return true;
            }
            else{
                return false;
            }
        }
        bool bLeft = HasSum(node.left, sum, now);
        bool bRight = HasSum(node.right, sum, now);
        return (bLeft || bRight);
    }
}