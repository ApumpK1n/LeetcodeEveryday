/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

using System.Collections.Generic;

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        List<ListNode> ret = new List<ListNode>();
        while(head!=null){
            ret.Add(head);
            head = head.next;
        }
        return (ret[ret.Count / 2]);
    }
}