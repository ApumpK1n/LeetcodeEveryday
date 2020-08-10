
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

// 99. 恢复二叉搜索树

/*
二叉搜索树中的两个节点被错误地交换。

请在不改变其结构的情况下，恢复这棵树。
*/

// 二叉搜索树满足根节点的左边元素小于等于根节点，右子树大于根节点
// 因此只要使用中序遍历就能构建一个有序数组，若有节点被交换，则会破坏节点的有序顺序，即为错误的两个节点。
public class Solution {
    TreeNode preNode = new TreeNode(int.MinValue);
    TreeNode firstNode = null;
    TreeNode secondNode = null;
    public void RecoverTree(TreeNode root) {
       
        recoverTree(root);
        int temp = firstNode.val;
        firstNode.val = secondNode.val;
        secondNode.val = temp;
        
    }

    private void recoverTree(TreeNode root){
        if (root == null) return;
        recoverTree(root.left);
        // 判断
        if (preNode.val > root.val && firstNode == null){
            firstNode = preNode;
        }
        if (preNode.val > root.val && firstNode != null){
            secondNode = root;
        }
        preNode = root;
        recoverTree(root.right);
    }
}