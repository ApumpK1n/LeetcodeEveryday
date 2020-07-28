
/*104. 二叉树的最大深度
给定一个二叉树，找出其最大深度。

二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。
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
public class Solution {
    public int MaxDepth(TreeNode root) {
        int res = MaxChildDepth(root, 0);
        return res;
    }

    public int MaxChildDepth(TreeNode node, int Num){
        if (node == null) return Num;
        Num += 1;
        int left = MaxChildDepth(node.left, Num);
        int right = MaxChildDepth(node.right, Num);
        return Math.Max(left, right);    
    }
}