/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 98. 验证二叉搜索树

// 递归
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return helper(root, null, null);
    }
    private bool helper(TreeNode node, TreeNode lower, TreeNode upper) {
        if (node == null) return true;

        int val = node.val;
        if (lower != null && val <= lower.val) return false;
        if (upper != null && val >= upper.val) return false;

        if (! helper(node.right, node, upper)) return false;
        if (! helper(node.left, lower, node)) return false;
        return true;
    }


}