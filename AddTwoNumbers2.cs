/*
给你两个 非空 链表来代表两个非负整数。数字最高位位于链表开始位置。它们的每个节点只存储一位数字。将这两数相加会返回一个新的链表。

你可以假设除了数字 0 之外，这两个数字都不会以零开头。
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 最高位到最低位，列表节点不能翻转。
//遍历链表保存为列表

using System.Collections.Generic;

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        List<int> List1 = new List<int>();
        List<int> List2 = new List<int>();
        while(l1 != null){
            List1.Insert(0, l1.val);
            l1 = l1.next;
        }
        while(l2 != null){
            List2.Insert(0, l2.val);
            l2 = l2.next;
        }
        int Num = Math.Min(List1.Count, List2.Count);
        ListNode currentNode = null; 
        int jinwei = 0;
        int i = 0;
        while(i < List1.Count || i< List2.Count){
            int num1 = 0;
            if (i < List1.Count) num1 = List1[i];
            int num2 = 0;
            if (i < List2.Count) num2 = List2[i];
            int total = num1 + num2 + jinwei;
            if (total >= 10) {
                jinwei = 1;
                total -= 10;
            } 
            else{
                jinwei = 0;
            }
            i++;
            ListNode node = new ListNode(total);
            node.next = currentNode;
            currentNode = node;
        }
        if (jinwei > 0){
            ListNode node = new ListNode(jinwei);
            node.next = currentNode;
            currentNode = node;
        }
        return currentNode;
    }
}