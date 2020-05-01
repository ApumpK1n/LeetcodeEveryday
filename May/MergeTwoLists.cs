/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

 // 没什么好说的，链表为升序遍历生成新链表即可
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        if (l1 == null && l2 == null) return null;

        ListNode res = new ListNode(0);

        ListNode start = res;

        while(l1 != null && l2 != null){
            
            if (l1.val <= l2.val){
                res.next = l1;
                l1 = l1.next;
                res = res.next;
            }
            else{
                res.next =  l2;
                l2 = l2.next;
                res = res.next;
            }
        }

        // 剩余的链表直接添加到尾部即可
        ListNode last = l1 == null ? l2 : l1;
        if (last != null){
            res.next = last;
        }

        return start.next;
    }
}