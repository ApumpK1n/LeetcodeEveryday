
// 538. 把二叉搜索树转换为累加树

/*
给定一个二叉搜索树（Binary Search Tree），把它转换成为累加树（Greater Tree)，使得每个节点的值是原来的节点值加上所有大于它的节点值之和。
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
    
    int num = 0; // 下一个右节点的数
    
    public TreeNode ConvertBST(TreeNode root) 
    {

        if (root == null) return null;

        ConvertBST(root.right);
        root.val += num;

        num = root.val;
        ConvertBST(root.left);

        return root;
    }

}