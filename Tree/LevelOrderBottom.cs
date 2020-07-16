/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {

        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Queue<List<TreeNode>> queue = new Queue<List<TreeNode>>();
        List<TreeNode> start = new List<TreeNode>();
        start.Add(root);
        queue.Enqueue(start);
        while(queue.Count > 0)
        {
            List<TreeNode> lstTreeNode = queue.Dequeue();
            List<int> num = new List<int>();
            List<TreeNode> next = new List<TreeNode>();
            foreach(TreeNode node in lstTreeNode){
                num.Add(node.val);
                if (node.left != null){
                    next.Add(node.left);
                }
                if (node.right != null){
                    next.Add(node.right);
                }
            }
            res.Add(num);
            if (next.Count > 0){
                queue.Enqueue(next);
            }
        }
        return res.Reverse().ToList();
    }
}