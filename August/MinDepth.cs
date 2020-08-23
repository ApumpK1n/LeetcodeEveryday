

    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */

    // 111. 二叉树的最小深度

    /*
    给定一个二叉树，找出其最小深度。
    最小深度是从根节点到最近叶子节点的最短路径上的节点数量。
    说明: 叶子节点是指没有子节点的节点。
    */
    public class Solution {
        public int MinDepth(TreeNode root) {
            if (root == null) return 0;

            if (root.left == null && root.right == null) return 1;
            int res = int.MaxValue;
            if (root.left != null){
                res = Math.Min(MinDepth(root.left), res);
            }
            if (root.right != null){
                res = Math.Min(MinDepth(root.right), res);
            }
            
            return res + 1;
        }
    }