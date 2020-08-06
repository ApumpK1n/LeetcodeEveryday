
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
// 100. 相同的树

/*
给定两个二叉树，编写一个函数来检验它们是否相同。

如果两个树在结构上相同，并且节点具有相同的值，则认为它们是相同的。
*/
// 先递归解法
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if ((p != null && q == null) || (p == null && q != null)) return false;
        if (p == null && q == null) return true;
        if (p.val != q.val) return false;
        bool left = IsSameTree(p.left, q.left);
        bool right = IsSameTree(p.right, q.right);
        return left && right;
    }

}