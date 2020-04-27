/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

 // 暴力解法
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0){
            return null;
        }
        ListNode first = lists[0];
        for (int i = 1; i < lists.Length; i++){
            first = MergeTwo(first, lists[i]);
        }
        return first;
    }

    private ListNode MergeTwo(ListNode a, ListNode b){
        ListNode ret = new ListNode(0);
        ListNode result = ret;
        ListNode pA = a;
        ListNode pB = b;
        while(pA != null && pB != null){
            if (pA.val <= pB.val){
                ret.next = pA;
                pA = pA.next;
                ret = ret.next;
            }
            else{
                ret.next = pB;
                pB = pB.next;
                ret = ret.next;
            }
        }
        ret.next = pA != null ? pA : pB;
        return result.next;
    }
}

// 两两合并, 分冶法

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0){
            return null;
        }
        return MergeTwo(lists, 0, lists.Length-1);
    }

    // [left, right]
    public ListNode MergeTwo(ListNode[] lists, int left, int right){
        if (left == right) return lists[left];
        int mid = left + (right - left) / 2;
        ListNode leftNode = MergeTwo(lists, left, mid);
        ListNode rightNode = MergeTwo(lists, mid + 1, right);
        return MergeTwo(leftNode, rightNode); 
    }

    private ListNode MergeTwo(ListNode a, ListNode b){
        ListNode ret = new ListNode(0);
        ListNode result = ret;
        ListNode pA = a;
        ListNode pB = b;
        while(pA != null && pB != null){
            if (pA.val <= pB.val){
                ret.next = pA;
                pA = pA.next;
                ret = ret.next;
            }
            else{
                ret.next = pB;
                pB = pB.next;
                ret = ret.next;
            }
        }
        ret.next = pA != null ? pA : pB;
        return result.next;
    }
}