
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

// 114. 二叉树展开为链表
/*
 给定一个二叉树，原地将它展开为一个单链表。
*/

// 这里看示例图遵循前序遍历, 但是以前序遍历会破坏原来的结构，所以改为后序遍历，反着接。
public class Solution {
    
    TreeNode pre = null;
    public void Flatten(TreeNode root) {
        if (root == null) return;
        Flatten(root.right);
        Flatten(root.left);
        root.right = pre;
        root.left = null;
        pre = root;
    }

}