//给定一棵二叉树，你需要计算它的直径长度。一棵二叉树的直径长度是任意两个结点路径长度中的最大值。这条路径可能穿过根结点。
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {

    int result = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        DiameterOfNode(root);
        return result;
    }

    public int DiameterOfNode(TreeNode node){
        if (node == null) return 0;
        int left = 0;
        int right = 0;
        if (node.left != null) left = DiameterOfNode(node.left) + 1;
        if (node.right != null) right = DiameterOfNode(node.right) + 1;
        result = Math.Max(left + right, result);
        return Math.Max(left, right);
    } 
}