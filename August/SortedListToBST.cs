/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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

// 109. 有序链表转换二叉搜索树

/*
给定一个单链表，其中的元素按升序排序，将其转换为高度平衡的二叉搜索树。

本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过 1。
*/

// 找到中值，然后中序遍历构建二叉树
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {

        if (head == null) return null;

        // 链表到末尾，不用寻找中值。
        if (head.next == null) return new TreeNode(head.val);

        // 找中心点
        ListNode p = head;
        ListNode q = head;
        ListNode pre = null;
        while(q != null && q.next != null){
            pre = p;
            p = p.next;
            q = q.next.next;
        }
        pre.next = null; // 截断

        TreeNode root = new TreeNode(p.val);
        root.left = SortedListToBST(head);
        root.right = SortedListToBST(p.next);
        return root;
    }
}