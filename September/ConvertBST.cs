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
    int num = 0; // 右节点的值
    public TreeNode ConvertBST(TreeNode root) {
        if(root == null) return root;

        ConvertBST(root.right);
        root.val += num;
        num = root.val;

        ConvertBST(root.left);

        return root;
    }
}