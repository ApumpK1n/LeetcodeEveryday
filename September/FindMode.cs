
// 501. 二叉搜索树中的众数

/*
给定一个有相同值的二叉搜索树（BST），找出 BST 中的所有众数（出现频率最高的元素）。

假定 BST 有如下定义：

结点左子树中所含结点的值小于等于当前结点的值
结点右子树中所含结点的值大于等于当前结点的值
左子树和右子树都是二叉搜索树
*/

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
        public int[] FindMode(TreeNode root)
        {
            if (root == null) return new int[0];

            m_maxCount = 0;
            m_maxNumList = new List<int>();

            m_curValue = int.MinValue;
            m_curCount = 0;

            Recursive(root);
            UpdateResult();

            return m_maxNumList.ToArray();
        }

        private int m_maxCount;
        private List<int> m_maxNumList;
        private int m_curValue;
        private int m_curCount;

        private void Recursive(TreeNode root)
        {
            if (root == null) return;

            Recursive(root.left);

            var curValue = root.val;
            if (curValue == m_curValue)
            {
                m_curCount++;
            }
            else
            {
                UpdateResult();

                m_curValue = curValue;
                m_curCount = 1;
            }

            Recursive(root.right);
        }

        private void UpdateResult()
        {
            if (m_curCount >= m_maxCount)
            {
                if (m_curCount > m_maxCount)
                {
                    m_maxCount = m_curCount;
                    m_maxNumList.Clear();
                }
                m_maxNumList.Add(m_curValue);
            }
        }
}