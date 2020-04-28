/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

/*
 二叉树的右视图
 给定一棵二叉树，想象自己站在它的右侧，按照从顶部到底部的顺序，返回从右侧所能看到的节点值。


想错了方向准备用递归做，没想到深度优先遍历

以后这种类似先遍历某个节点的做法都可以是深度优先遍历, 抽象出深度的概念，管理不同层级记录的节点

*/

using System.Collections.Generic;

public class Solution {
    public IList<int> RightSideView(TreeNode root) {

        List<int> result = new List<int>();


        void Dfs(TreeNode node, int deepth){
            if (node == null) return;
            if (deepth == result.Count){
                result.Add(node.val);
            }

            Dfs(node.right, deepth + 1);
            Dfs(node.left, deepth + 1);
        }

        Dfs(root, 0);
        return result;
    }

}