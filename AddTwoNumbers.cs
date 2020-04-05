
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

//第一次做时理解错了题义，把两个链表都转成了整数，然后相加的形式，后来发现会溢出

//第二次才发现实际上这就是一个遍历链表，对应节点数分别相加，注意进位的题。之前被逆序干扰了，实际上顺序遍历节点就可以，因为会经过两次逆序。

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int jinwei = 0;
        ListNode head = new ListNode(0);
        ListNode current = head;
        while(l1 != null || l2 != null){
            int l1Num = 0;
            if (l1 != null) l1Num = l1.val;
            int l2Num = 0;
            if (l2 != null) l2Num = l2.val;
            int total = l1Num + l2Num;
            if (jinwei > 0) total += jinwei;
            if (total >= 10) {
                jinwei = 1;
                total -= 10;
            }
            else jinwei = 0;
            ListNode node = new ListNode(total);
            current.next = node;
            current = current.next;
            if (l1 == null || l1.next == null) l1 = null;
            else l1 = l1.next;
            if (l2 == null || l2.next == null) l2 = null;
            else l2 = l2.next;
        }
        if (jinwei > 0) current.next = new ListNode(jinwei);
        return head.next;
    }
}
