

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

// 572. 另一个树的子树
// 给定两个非空二叉树 s 和 t，检验 s 中是否包含和 t 具有相同结构和节点值的子树。s 的一个子树包括 s 的一个节点和这个节点的所有子孙。s 也可以看做它自身的一棵子树。

// 先递归

public class Solution {
    public bool IsSubtree(TreeNode s, TreeNode t) {
        return Dfs(s, t);
    }

    private bool Dfs(TreeNode s, TreeNode t){
        if (s == null) return false;
        return CheckSub(s, t) || Dfs(s.left, t) || Dfs(s.right, t);
    }


    private bool CheckSub(TreeNode s, TreeNode t){
        if (s==null && t==null) return true;
        if(s != null && t == null)return false;
        if(s == null && t != null)return false;
        if (s.val != t.val) return false;
        return CheckSub(s.left, t.left) && CheckSub(s.right, t.right);
    }
}