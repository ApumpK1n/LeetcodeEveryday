

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 148. 排序链表

// 在 O(n log n) 时间复杂度和常数级空间复杂度下，对链表进行排序。

public class Solution {
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null){
            return head;
        }
        ListNode fast = head.next;
        ListNode slow = head;
        // 找到中值
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode tmp = slow.next;
        slow.next = null;
        // 拆分
        ListNode left = SortList(head);
        ListNode right = SortList(tmp);
        ListNode res = new ListNode(0);
        ListNode node = res;
        // 合并
        while(left != null && right != null){
            if (left.val < right.val){
                node.next = left;
                left = left.next;
            }
            else{
                node.next = right;
                right = right.next;
            }
            node = node.next;
        }
        node.next = left == null ? right : left;
        return res.next;
    }
}