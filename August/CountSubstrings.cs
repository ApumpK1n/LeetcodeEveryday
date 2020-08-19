

// 647. 回文子串

/*
给定一个字符串，你的任务是计算这个字符串中有多少个回文子串。
具有不同开始位置或结束位置的子串，即使是由相同的字符组成，也会被视作不同的子串。
*/

// 动态规划

public class Solution {
    public int CountSubstrings(string s) {
        
        int n = s.Length;
        bool[,] dp = new bool[n,n];

        int result = 0;
        for(int i=n-1; i>=0; i--){
            dp[i, i] = true;
            result += 1;
            for(int j=i+1; j<n; j++){
                if (j - i < 2){
                    dp[i, j] = s[i] == s[j];
                }
                else{
                    dp[i, j] = dp[i+1, j-1] && s[i] == s[j];
                }
                if (dp[i, j]){
                    result += 1;
                }
            }
        }
        return result;
    }
}