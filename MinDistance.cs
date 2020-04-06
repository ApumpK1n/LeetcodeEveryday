// 编辑距离
//初见直接懵逼，看题解后方知使用动态规划
/*
在单词 A 中插入一个字符：如果我们知道 horse 到 ro 的编辑距离为 a，那么显然 horse 到 ros 的编辑距离不会超过 a + 1。这是因为我们可以在 a 次操作后将 horse 和 ro 变为相同的字符串，只需要额外的 1 次操作，在单词 A 的末尾添加字符 s，就能在 a + 1 次操作后将 horse 和 ro 变为相同的字符串；
在单词 B 中插入一个字符：如果我们知道 hors 到 ros 的编辑距离为 b，那么显然 horse 到 ros 的编辑距离不会超过 b + 1，原因同上；
修改单词 A 的一个字符：如果我们知道 hors 到 ro 的编辑距离为 c，那么显然 horse 到 ros 的编辑距离不会超过 c + 1，原因同上。
*/
// dp[i][j]表示word1的前i个字母转换成word2的前j个字母所使用的最少操作。
// 所以可以抽象出3个操作，判断3个操作的最小值即可


public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length;
        int n = word2.Length;
        if (m * n == 0) return m + n;
        int [,] dp = new int[m + 1, n + 1];
        // 初始值
        for (int i = 0; i < m + 1; i++) {
            dp[i, 0] = i;
        }
        for (int j = 0; j < n + 1; j++) {
            dp[0, j] = j;
        }

        for (int i = 1; i < m + 1; i++){
            for(int j = 1; j < n + 1; j++){
                int AInsert = dp[i-1, j] + 1;
                int BInsert = dp[i, j-1] + 1;
                int Change = dp[i-1, j-1];
                if (word1[i-1] != word2[j-1]) Change += 1;
                dp[i, j] = Math.Min(AInsert, Math.Min(BInsert, Change));
            }
        }

        return dp[m, n];
    }
}