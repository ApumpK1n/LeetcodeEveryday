/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Collections.Generic;

// 101. 对称二叉树
// 给定一个二叉树，检查它是否是镜像对称的。
//递归
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsSymmetric(root, root);
    }

    private bool IsSymmetric(TreeNode left, TreeNode right){
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        return (left.val == right.val && IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left));
    }
}

// 迭代


public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        queue.Enqueue(root);
        while(queue.Count > 0){
            TreeNode left = queue.Dequeue();
            TreeNode right = queue.Dequeue();
            if (left == null && right == null) continue;
            if (left == null || right == null) return false;
            if (left.val == right.val){
                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);
            }
            else{
                return false;
            }
        }
        return true;
    }
}
