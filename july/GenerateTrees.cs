
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// 95. 不同的二叉搜索树 II

// 给定一个整数 n，生成所有由 1 ... n 为节点所组成的 二叉搜索树 。
using System.Collections.Generic;

public class Solution {
    public IList<TreeNode> GenerateTrees(int n) {
        List<TreeNode> res = new List<TreeNode>();
        if (n == 0) return res;
        return generateTrees(1, n);
    }

    private List<TreeNode> generateTrees(int start, int end){
        List<TreeNode> allTrees = new List<TreeNode>();
        if (start > end){
            allTrees.Add(null);
            return allTrees;
        }
        
        for(int i=start; i<=end; i++)
        {
            List<TreeNode> leftTrees = generateTrees(start, i-1);
            List<TreeNode> rightTrees = generateTrees(i+1, end);

            foreach(TreeNode left in leftTrees){
                foreach(TreeNode right in rightTrees){
                    TreeNode node = new TreeNode(i);
                    node.left = left;
                    node.right = right;
                    allTrees.Add(node);
                }
            }
        }
        return allTrees;
    }
}