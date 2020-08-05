
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// 337. 打家劫舍 III

/*
在上次打劫完一条街道之后和一圈房屋后，小偷又发现了一个新的可行窃的地区。这个地区只有一个入口，我们称之为“根”。 除了“根”之外，每栋房子有且只有一个“父“房子与之相连。一番侦察之后，聪明的小偷意识到“这个地方的所有房屋的排列类似于一棵二叉树”。 如果两个直接相连的房子在同一天晚上被打劫，房屋将自动报警。

计算在不触动警报的情况下，小偷一晚能够盗取的最高金额。
*/

// 树形Dp问题
// 最大利润左右子树最大利润的和

public class Solution {
    public int Rob(TreeNode root) {
        int[] dp = dfs(root);
        return Math.Max(dp[0], dp[1]);
    }

    private int[] dfs(TreeNode node){
        int[] dp = new int[2]{0, 0}; // 节点抢或不抢
        if (node == null) return dp;
        int[] left = dfs(node.left);
        int[] right = dfs(node.right);
        // 有两种情况，根据根节点抢或者不抢
        int rob = left[1] + right[1] + node.val; // 根节点抢，子节点不抢
        int dontrob = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);// 根节点不抢，子节点抢或者不抢。
        dp[0] = rob;
        dp[1] = dontrob;
        return dp;
    }   
}