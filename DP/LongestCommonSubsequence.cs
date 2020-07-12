// 1143. 最长公共子序列

/*
给定两个字符串 text1 和 text2，返回这两个字符串的最长公共子序列的长度。

一个字符串的 子序列 是指这样一个新的字符串：它是由原字符串在不改变字符的相对顺序的情况下删除某些字符（也可以不删除任何字符）后组成的新字符串。
例如，"ace" 是 "abcde" 的子序列，但 "aec" 不是 "abcde" 的子序列。两个字符串的「公共子序列」是这两个字符串所共同拥有的子序列。

若这两个字符串没有公共子序列，则返回 0。
*/

// 如果前一个是公共子序列则相等时也为公共子序列
// dp[i][j] 为上一个i位置和下一个字串j位置是否为公共子序列

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int len1 = text1.Length;
        int len2 = text2.Length;
        if (len1 == 0 || len2 == 0) return 0;

        bool[,] dp = new bool[len1, len2]{false};
        for(int i=0; i<len1; i++){
            for(int j=0; j<len2; j++){
                if (text1[i] == text2[j]){
                    if (i==0 && j==0){
                        dp[i,j] = true;
                    }
                    else{
                        
                    }
                }
            }
        }

    }
}