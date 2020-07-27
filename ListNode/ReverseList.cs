

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 剑指 Offer 24. 反转链表
public class Solution {
    public ListNode ReverseList(ListNode head) {

        ListNode next = null;
        ListNode pre = null;

        while(head != null){
            next = head.next;
            head.next = pre;
            pre = head;
            head = next;
        }
        return pre;
    }
}