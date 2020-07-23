

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
// 25. K 个一组翻转链表
/*
给你一个链表，每 k 个节点一组进行翻转，请你返回翻转后的链表。
k 是一个正整数，它的值小于或等于链表的长度。
如果节点总数不是 k 的整数倍，那么请将最后剩余的节点保持原有顺序。
*/
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode check = head;
        ListNode ret = new ListNode(0);
        ret.next = head;
        ListNode curr = head;
        ListNode pre = ret;
        ListNode next = null;
        int checkNum = 0;
        while(check != null){
            checkNum += 1;
            check = check.next;
        }

        for(int i=0; i<checkNum/k; i++){
            for(int j=0; j<k -1; j++){
                next = curr.next;
                curr.next = next.next;
                next.next = pre.next;
                pre.next = next;
            }
            pre = curr;
            curr = pre.next;
        }
        return ret.next;
    }
}