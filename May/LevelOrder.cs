/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 102. 二叉树的层序遍历
// 给你一个二叉树，请你返回其按 层序遍历 得到的节点值。 （即逐层地，从左到右访问所有节点）。
// 递归就行

using System.Collections.Generic;
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> ret = new List<IList<int>>();
        LevelList(ret, root, 0);
        return ret;
    }

    private void LevelList(List<IList<int>> ret, TreeNode node, int deepth){
        if (node == null) return;
        if (ret.Count > deepth){ //判断这层是否已经添加过元素
            ret[deepth].Add(node.val);
        }
        else{
            ret.Add(new List<int>(){node.val});
        }
        // 先遍历左子树，再遍历右子树
        LevelList(ret, node.left, deepth + 1);
        LevelList(ret, node.right, deepth + 1);
    }
    
}