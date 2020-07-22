

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 94. 二叉树的中序遍历
// 给定一个二叉树，返回它的中序 遍历。

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {

        List<int> lstRes = new List<int>();
        inorderTraversal(root, lstRes);
        return lstRes;
    }

    private void inorderTraversal(TreeNode node, List<int> lstRes){
        if (node == null) return;
        inorderTraversal(node.left, lstRes);
        lstRes.Add(node.val);
        inorderTraversal(node.right, lstRes);
        
    }
}