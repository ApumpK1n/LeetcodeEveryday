/*
1161. 最大层内元素和
给你一个二叉树的根节点 root。设根节点位于二叉树的第 1 层，而根节点的子节点位于第 2 层，依此类推。

返回总和 最大 的那一层的层号 x。如果有多层的总和一样大，返回其中 最小 的层号 x。
*/
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
//二叉树层序遍历 使用队列，一层层来
using System.Collections;
public class Solution {
    public int MaxLevelSum(TreeNode root)
    {
        if (root == null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int layer = 0;
        int sum = int.MinValue;
        int layerTemp = 0;
        while(queue.Count > 0)
        {
            layerTemp++;
            int layerSum = 0;
            int layerNodeCount = queue.Count;
            for(int i=0; i<layerNodeCount; i++){
                var node = queue.Dequeue();
                layerSum += node.val; 
                
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            if (layerSum > sum)
            {
                layer = layerTemp;
                sum = layerSum;
            }

        }
        return layer;
    }
}
