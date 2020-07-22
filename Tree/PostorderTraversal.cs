
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 145. 二叉树的后序遍历
// 给定一个二叉树，返回它的 后序 遍历。

public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> lstRes = new List<int>();
        preorderTraversal(root, lstRes);
        return lstRes;
    }

    private void preorderTraversal(TreeNode node, List<int> lstRes){
        if (node == null) return;
        preorderTraversal(node.left, lstRes);
        preorderTraversal(node.right, lstRes);
        lstRes.Add(node.val);
    } 
}
