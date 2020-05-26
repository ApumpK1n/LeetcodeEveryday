/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if(preorder.Length == 0)
                return null;
            return BuildTreeHelper(preorder, inorder, 0, inorder.Length - 1, 0);
        }

        public TreeNode BuildTreeHelper(int[] preorder, int[] inorder, int start, int end, int root)
        {
            TreeNode rootNode = new TreeNode(preorder[root]);
            // 判断是否为叶节点
            if (start == end)
                return rootNode;
            for(int i = start; i <= end; i++)
            {
                if(inorder[i] == preorder[root])
                {
                    //判断左子树内是否有元素
                    rootNode.left =i>start? BuildTreeHelper(preorder, inorder, start, i - 1, root + 1) : null;
                    //判断右子树内是否有元素
                    rootNode.right= i<end ? BuildTreeHelper(preorder, inorder, i + 1, end, root + i - start + 1): null;
                }
            }

            return rootNode;
        }
}