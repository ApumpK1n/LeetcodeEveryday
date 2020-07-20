/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

using System.Collections.Generic;
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        
        List<ListNode> lstNode = new List<ListNode>();
        while(head != null){
            if (lstNode.Contains(head)){
                return head;
            }
            lstNode.Add(head);
            head = head.next;
        }
        return null;
    }
}