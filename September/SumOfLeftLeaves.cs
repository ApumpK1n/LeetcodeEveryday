

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 404. 左叶子之和

// 计算给定二叉树的所有左叶子之和。
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        return sumOfLeftLeaves(root, 0, false);
    }

    private int sumOfLeftLeaves(TreeNode node, int res, bool flag){
        if (node == null) return res;
        if (node.left == null && node.right == null && flag){
            res += node.val;
        }
        res = sumOfLeftLeaves(node.left, res, true);
        res = sumOfLeftLeaves(node.right, res, false);
        return res;
    }
}