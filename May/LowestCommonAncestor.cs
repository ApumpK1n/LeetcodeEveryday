/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

/*
236. 二叉树的最近公共祖先

*/

public class Solution {
    
    TreeNode ans;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        dfs(root, p, q);
        return ans;
    }

    private bool dfs(TreeNode root, TreeNode p, TreeNode q){
        if (root == null) return false;
        bool lSon = dfs(root.left, p, q);
        bool rSon = dfs(root.right, p, q);
        if ((lSon && rSon) || ((root.val == p.val || root.val == q.val) && (lSon || rSon))){
            ans = root;
        }
        return lSon || rSon || (root.val == p.val || root.val == q.val);
    }
}