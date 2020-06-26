/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 面试题 02.01. 移除重复节点
// 编写代码，移除未排序链表中的重复节点。保留最开始出现的节点。
using System.Collections.Generic;
public class Solution {
    public ListNode RemoveDuplicateNodes(ListNode head) {
        List<int> compare = new List<int>();
        ListNode start = head;
        ListNode Last = head;
        while(head != null){
            if (!compare.Contains(head.val)){
                compare.Add(head.val);
                 Last = head;
            }
            else{
                Last.next = head.next;
            }
           
            head = head.next;
        }
        return start;
    }
}

// 使用HashSet

public class Solution {
    public ListNode RemoveDuplicateNodes(ListNode head) {
        HashSet<int> compare = new HashSet<int>();
        ListNode start = head;
        ListNode Last = head;
        while(head != null){
            if (!compare.Contains(head.val)){
                compare.Add(head.val);
                 Last = head;
            }
            else{
                Last.next = head.next;
            }
           
            head = head.next;
        }
        return start;
    }
}