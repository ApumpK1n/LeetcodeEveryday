// 141. 环形链表

/*
给定一个链表，判断链表中是否有环。

如果链表中有某个节点，可以通过连续跟踪 next 指针再次到达，则链表中存在环。 为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。注意：pos 不作为参数进行传递，仅仅是为了标识链表的实际情况。

如果链表中存在环，则返回 true 。 否则，返回 false 。
*/

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
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> ret = new HashSet<ListNode>();
        while(head != null){
            if (ret.Contains(head)) return true;
            ret.Add(head);
            head = head.next;
        }
        return false;
    }
}