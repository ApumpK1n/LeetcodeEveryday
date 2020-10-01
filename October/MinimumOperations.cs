/*
小扣出去秋游，途中收集了一些红叶和黄叶，他利用这些叶子初步整理了一份秋叶收藏集 leaves， 字符串 leaves 仅包含小写字符 r 和 y， 其中字符 r 表示一片红叶，字符 y 表示一片黄叶。
出于美观整齐的考虑，小扣想要将收藏集中树叶的排列调整成「红、黄、红」三部分。每部分树叶数量可以不相等，但均需大于等于 1。每次调整操作，小扣可以将一片红叶替换成黄叶或者将一片黄叶替换成红叶。请问小扣最少需要多少次调整操作才能将秋叶收藏集调整完毕。
*/

public class Solution {
    public int MinimumOperations(string leaves)
    {
        int IsYellow(char c) => c.Equals('y') ? 1 : 0;
        int IsRed(char c) => c.Equals('r') ? 1 : 0;
        // dp[i][j] 对第0到第i片叶子进行操作 => 最优解  [0 红 1 黄 2 红]
        var dp = new int[leaves.Length, 3];
        dp[0, 0] = IsYellow(leaves[0]); // 是黄置红
        dp[0, 1] = dp[0, 2] = dp[1, 2] = int.MaxValue;
        
        for (int i = 1; i < leaves.Length; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + IsYellow(leaves[i]); // 是黄置红
            dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + IsRed(leaves[i]); // 是红置黄
            if (i >= 2)
                dp[i, 2] = Math.Min(dp[i - 1, 1], dp[i - 1, 2])  + IsYellow(leaves[i]); // 是黄置红
        }

        return dp[leaves.Length - 1, 2];
    }
}