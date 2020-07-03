// 108. 将有序数组转换为二叉搜索树

/*
将一个按照升序排列的有序数组，转换为一棵高度平衡二叉搜索树。

本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过 1。
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
 // 递归，因为是左右子树高度差不超过1，所以取中间长度分别递归。
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return Build(nums, 0, nums.Length - 1);
    }

    private TreeNode Build(int[] nums, int left, int right){
        if (left > right) return null;
        int middle = left + (right - left) / 2;
        TreeNode node = new TreeNode(nums[middle]);
        node.left = Build(nums, left, middle - 1);
        node.right = Build(nums, middle + 1, right);
        return node;
    }
}