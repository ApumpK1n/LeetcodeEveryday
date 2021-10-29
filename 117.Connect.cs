/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/


/*
117. 填充每个节点的下一个右侧节点指针 II
给定一个二叉树

struct Node {
  int val;
  Node *left;
  Node *right;
  Node *next;
}
填充它的每个 next 指针，让这个指针指向其下一个右侧节点。如果找不到下一个右侧节点，则将 next 指针设置为 NULL。

初始状态下，所有 next 指针都被设置为 NULL。

进阶：

你只能使用常量级额外空间。
使用递归解题也符合要求，本题中递归程序占用的栈空间不算做额外的空间复杂度。

*/

// 二叉树层序遍历
using System.Collections;

public class Solution {
    public Node Connect(Node root) {
        if (root == null) return null;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            Node last = null;
            int n = queue.Count;
            for(int i=0; i < n; i++)
            {
                Node node = queue.Dequeue();

                if (i != 0)
                {
                    last.next = node;
                }
                
                last = node;

                // 加入下一层的. 从左到右
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }

        return root;

    }
}